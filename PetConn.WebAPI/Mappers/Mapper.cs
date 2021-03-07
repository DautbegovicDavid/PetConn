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


            CreateMap<Proizvodjac, Database.Proizvodjac>().ReverseMap();
            CreateMap<ProizvodjacUpsertRequest, Database.Proizvodjac>().ReverseMap();

            CreateMap<JedinicaMjere, Database.JedinicaMjere>().ReverseMap();
            CreateMap<JedinicaMjereUpsertRequest, Database.JedinicaMjere>().ReverseMap();

            CreateMap<VrstaProizvoda, Database.VrstaProizvodum>().ReverseMap();
            CreateMap<VrstaProizvodaUpsertRequest, Database.VrstaProizvodum>().ReverseMap();

            CreateMap<Uloge, Database.Uloga>().ReverseMap();
            CreateMap<VrstePartnera, Database.VrstaPartnera>().ReverseMap();
            CreateMap<KorisnikUloge, Database.KorisniciUloge>().ReverseMap();  
            CreateMap<Partner, Database.Partneri>().ReverseMap();
            CreateMap<VrstaPartnera, Database.VrstaPartnera>().ReverseMap();
            CreateMap<Poslovnica, Database.Poslovnica>().ReverseMap();
            CreateMap<PoslovnicaUpsertRequest, Database.Poslovnica>().ReverseMap();
            CreateMap<PartneriSearchRequest, Database.Partneri>().ReverseMap();
            CreateMap<PartneriSearchRequest, Partner>().ReverseMap();
            CreateMap<Lokacija, Database.Lokacija>().ReverseMap();
            CreateMap<Database.Lokacija, LokacijaUpsertRequest>().ReverseMap();
            CreateMap<Database.Partneri, PartneriUpsertRequest>().ReverseMap();
            CreateMap<Database.Uposlenik, UposlenikUpsertRequest>().ReverseMap();
            CreateMap<Database.Uposlenik, Uposlenik>().ReverseMap();
            CreateMap<Database.KorisniciUloge, KorisniciUloge>().ReverseMap();
            CreateMap<Database.KorisniciUloge, KorisniciUlogeUpsertRequest>().ReverseMap();
            CreateMap<Database.Ljubimac, LjubimacUpsertRequest>().ReverseMap();
            CreateMap<Database.Ljubimac, Ljubimac>().ReverseMap();





            //CreateMap<Database.Korisnik, KorisnikUpsertRequest>().ReverseMap();   ISTI   NOVI


            //CreateMap<Database.Korisnik, Korisnik>()
            //    .ForMember(dest => dest.KorisniciUloges, opt => opt.MapFrom(src => src.KorisniciUloges)); NOVI

            //CreateMap<Database.KorisniciUloge, KorisnikUloge>().ForMember(dest => dest.Uloga, opt => opt.MapFrom(src => src.Uloga));  NOVI



        }
    }
}
