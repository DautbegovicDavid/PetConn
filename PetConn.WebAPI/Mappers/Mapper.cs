    using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetConn.Model.Requests;
using PetConn.Model.HelpModels;
using PetConn.Model;


namespace PetConn.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.Korisnik, Korisnik>().ReverseMap();
            CreateMap<Database.Korisnik, KorisnikUpsertRequest>().ReverseMap();
            CreateMap<Korisnik,KorisnikUpsertRequest>().ReverseMap();
            CreateMap<Drzava, Database.Drzava>().ReverseMap();
            CreateMap<DrzavaUpsert, Database.Drzava>().ReverseMap();
            CreateMap<Grad, Database.Grad>().ReverseMap();
            CreateMap<GradUpsert, Database.Grad>().ReverseMap();
            CreateMap<Uloge, Database.Uloga>().ReverseMap();
            CreateMap<VrstePartnera, Database.VrstaPartnera>().ReverseMap();
            CreateMap<KorisnikUloge, Database.KorisniciUloge>().ReverseMap();  //OD PRIJE
            CreateMap<Partner, Database.Partneri>().ReverseMap();

            //CreateMap<Database.Korisnik, KorisnikUpsertRequest>().ReverseMap();   ISTI   NOVI


            //CreateMap<Database.Korisnik, Korisnik>()
            //    .ForMember(dest => dest.KorisniciUloges, opt => opt.MapFrom(src => src.KorisniciUloges)); NOVI

            //CreateMap<Database.KorisniciUloge, KorisnikUloge>().ForMember(dest => dest.Uloga, opt => opt.MapFrom(src => src.Uloga));  NOVI
             


        }
    }
}
