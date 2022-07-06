using Burger.Entities;

namespace Burger.BL.Abstract
{
    public interface IKategoriManager : IManagerBase<Kategori>
    {
        bool IsmiKontrolEt(string KategoriAdi);
    }
}
