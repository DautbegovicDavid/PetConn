using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Hubs
{
    public class ChatHub:Hub//all logic 
    {
        private readonly firstTryContext _context;
        public ChatHub(firstTryContext context)
        {
            _context = context;
        }
        public int GetSenderID(string sender)
        {
            int x = _context.Korisniks.Where(w => w.KorisnickoIme == sender).Select(s => s.KorisnikId).FirstOrDefault();
            return x;
        }
        public int GetReciverID(string reciver)
        {
            int x = _context.Korisniks.Where(w => w.KorisnickoIme == reciver).Select(s => s.KorisnikId).FirstOrDefault();
            return x;
        }
        public async Task LoadOldMessages(string sender, string reciver)
        {
            int posiljaoc = GetSenderID(sender);
            int primaoc = GetReciverID(reciver);

            List<Poruka> poruke = _context.Porukas.Include(i => i.Posiljalac).Include(i => i.Primalac).Where(w => (w.PosiljalacId == posiljaoc || w.PrimalacId == posiljaoc) && (w.PosiljalacId == primaoc || w.PrimalacId == primaoc)).ToList();

            foreach (Poruka m in poruke)
            {
                //await Clients.All.SendAsync("ReceiveOldMessage", m.Sender.UserName.ToString(), m.Recipient.UserName.ToString(), m.Content);
                await Clients.Caller.SendAsync("ReceiveOldMessage", m.Posiljalac.KorisnickoIme.ToString(), m.Primalac.KorisnickoIme.ToString(), m.Sadrzaj);

            }

        }
        public async Task SendPrivateMessage(string sender, string reciver, string message)
        {
            int posiljaoc = GetSenderID(sender);
            int primaoc = GetReciverID(reciver);

            Poruka m = new Poruka { Sadrzaj = message, PrimalacId = primaoc, PosiljalacId = posiljaoc, Datum = DateTime.Now };
            await _context.AddAsync(m);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("ReceivePrivateMessage", sender, reciver, message);

        }
    }
}
