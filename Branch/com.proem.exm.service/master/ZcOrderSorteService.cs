using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using Branch.com.proem.exm.service.main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch.com.proem.exm.service.master
{
    public class ZcOrderSorteService
    {

        public List<ZcOrderSorte> FindByStreet()
        {
            ZcOrderSorteDao dao = new ZcOrderSorteDao();
            DownloadIdentifyService service = new DownloadIdentifyService();
            DateTime lastUpdate = service.GetLastUpdate();
            return dao.FindByStreet(lastUpdate);
        }
    }
}
