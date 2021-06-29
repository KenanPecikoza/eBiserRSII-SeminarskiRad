using eBiser.Data.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiser.Services
{
    public interface IKorisniciService
    {
        List<Data.KorisniciSistema> Get(KorisniciSearchRequest search);
        Data.KorisniciSistema GetById(int id);
        Data.KorisniciSistema Insert(KorisniciInserttRequest request);
        Data.KorisniciSistema Update(int id, KorisniciUpdateRequest request);
        Data.DonatorDTO GetDonator(int id);
        List<Data.DonatorDTO> GetDonatori();
        Data.ClanDTO GetClan(int id);
        List<Data.ClanDTO> GetCLanovi();
        Data.OsobljeDTO GetOsoblje(int id);
        List<Data.OsobljeDTO> GetOsoblje();
    }
}
