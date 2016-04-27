using Branch.com.proem.exm.dao.master;
using Branch.com.proem.exm.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Branch.com.proem.exm.service.master
{
    public class SetCodeToBranchService
    {

        public void setIdCodeToBranch(string code, ZcBranchTotal zcBranchTotal, string id)
        {
            SetCodeToBranchDao dao = new SetCodeToBranchDao();
            dao.setIdCodeToBranch(code, zcBranchTotal, id);
        }
    }
}
