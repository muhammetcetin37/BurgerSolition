using Burger.BL.Abstract;
using Burger.Entities;

namespace Burger.BL.Concrete
{
    public class KategoriManager : ManagerBase<Kategori>, IKategoriManager
    {
        //Ayni Kategori isminden bir daha olmasın
        //1- git db ye bak eger aynı isimde kayıt varsa true gonder
        public bool IsmiKontrolEt(string KategoriAdi)
        {
            var sonuc = base.repository.GetAll(p => p.KategoriAdi == KategoriAdi);
            if (sonuc != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int Add(Kategori input)
        {
            if (!IsmiKontrolEt(input.KategoriAdi))
            {
                return base.Add(input);
            }
            else
            {
                return -1;
            }
        }
    }
}
