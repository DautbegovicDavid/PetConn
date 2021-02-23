using AutoMapper;
using Microsoft.EntityFrameworkCore;

using PetConn.Model.Requests;
using PetConn.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PetConn.WebAPI.Services
{
    public class KorisniciService :IKorisniciService
    {
        private readonly firstTryContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(IMapper mapper, firstTryContext context)
        {
            _context = context;
            _mapper = mapper;
        }
        public  Model.Korisnik Insert(KorisnikUpsertRequest request)
        {
         
            if (request.Password != request.PasswordConfirmation)
                throw new Exception("passwordi nisu jednaki");

            var entity = _mapper.Map<Korisnik>(request);

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisniks.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Korisnik>(entity);
        }
        public  List<Model.Korisnik> Get(KorisnikSearchRequest request)
        {
            var query = _context.Korisniks.Include("KorisniciUloges.Uloga").AsQueryable();

            if(!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Equals(request.KorisnickoIme));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            var query2 = _context.Korisniks.AsQueryable();
            if (request?.UlogaId != null && request?.UlogaId != 0)
            {
                var korisnicIDs = _context.KorisniciUloges.Where(x => x.UlogaId == request.UlogaId).Select(s=>s.KorisnikId).ToArray();
                foreach (var item in korisnicIDs)
                {
                    query = query.Where(x => x.KorisnikId == item);
                }
                if (korisnicIDs.Count() == 0)
                    query = Enumerable.Empty<Korisnik>().AsQueryable();
            }

            if (request?.VrstaPartneraId != null&& request?.VrstaPartneraId != 0)
            {
                var partnerIDs = _context.Partneris.Where(x => x.VrstaPartneraId == request.VrstaPartneraId).Select(s => s.PartnerId).ToList();
                List<int> korisniksID=null;
                foreach (var item in partnerIDs)
                {
                    korisniksID = _context.Uposleniks.Where(w => w.PartnerId == item).Select(s => s.KorisnikId).ToList();
                    
                }
                if (korisniksID != null)
                {
                    foreach (var item in korisniksID)
                    {
                        query = query.Where(x => x.KorisnikId == item);
                    }
                }
                if (partnerIDs.Count() == 0)
                    query = Enumerable.Empty<Korisnik>().AsQueryable();//prazna lista
            }

            var list = query.ToList();
            return _mapper.Map<List<Model.Korisnik>>(list);
           
        }
        public Model.Korisnik GetByID(int id)
        {
            var entity = _context.Korisniks.Find(id);
            return _mapper.Map<Model.Korisnik>(entity);
        }
        public Model.Korisnik Update(int id, KorisnikUpsertRequest request)
        {
            var entity = _context.Korisniks.Find(id);
            _context.Korisniks.Attach(entity);
            _context.Korisniks.Update(entity);
            _mapper.Map(request, entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }
        public Model.Korisnik Delete(int id)
        {
            var entity = _context.Korisniks.Find(id);
            _context.Korisniks.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Korisnik>(entity);
        }
        
        
        public static string GenerateSalt()//implementacija rendom broja
        {
            var buf = new byte[16];
            new RNGCryptoServiceProvider().GetBytes(buf);
            return Convert.ToBase64String(buf);//zasto vracamo u string,zbog baze nekad se zajebe=pretvara bajte u string koji je citljiv iz pajtona browsera...

        }
        public static string GenerateHash(string salt, string pass)
        {
            //skontati kako radi
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            byte[] dst = new byte[src.Length + bytes.Length];

            Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm alg = HashAlgorithm.Create("SHA1");
            byte[] inArray = alg.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        public Model.Korisnik Authenticiraj(string user, string pass)
        {
            var u = _context.Korisniks.Include("KorisniciUloges.Uloga").FirstOrDefault(x => x.KorisnickoIme == user);
            if(u!=null)
            {
                //dobili smo password u clear pa ga hasiramo i vidimo da li se slaze s onim u bazi
                var newHash = GenerateHash(u.LozinkaSalt, pass);
                if(newHash==u.LozinkaHash)
                {
                    return _mapper.Map<Model.Korisnik>(u);
                }
            }
            return null;
        }

        public Model.Partner getPartnerID(KorisnikSearchRequest request)
        {
            //pazi da ne budu null parametri ERROR
            var user = _context.Korisniks.Where(x => x.KorisnickoIme == request.KorisnickoIme).FirstOrDefault();
            var userID = user.KorisnikId;
            var partner = _context.Uposleniks.Find(userID);
            //if(partner!=null)
            var partnerID = partner.PartnerId;
            var partners = _context.Partneris.Find(partnerID);
            return _mapper.Map<Model.Partner>(partners);

        }
        public Model.Partner getUloga(KorisnikSearchRequest request)
        {
            var user = _context.Korisniks.Where(x => x.KorisnickoIme == request.KorisnickoIme).FirstOrDefault();
            var userID = user.KorisnikId;
            var partner = _context.Uposleniks.Find(userID);
            var partnerID = partner.PartnerId;
            var partners = _context.Partneris.Find(partnerID);
            return _mapper.Map<Model.Partner>(partners);

        }

        public List<int> getUlogeIDs(int korisnikID)
        {
            return _context.KorisniciUloges.Where(w => w.KorisnikId == korisnikID).Select(s => s.UlogaId).ToList();

        }

        public int GetID(KorisnikSearchRequest k)
        {
            return _context.Korisniks.Where(w => w.KorisnickoIme == k.KorisnickoIme).Select(s => s.KorisnikId).FirstOrDefault();
        }

        
    }
}
