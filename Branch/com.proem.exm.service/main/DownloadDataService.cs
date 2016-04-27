using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Branch.com.proem.exm.service.branch;
using Branch.com.proem.exm.service.master;
using Branch.com.proem.exm.domain;
using System.Threading;
using Branch.com.proem.exm.window.main;
using System.Diagnostics;
using log4net;

namespace Branch.com.proem.exm.service.main
{
    class DownloadDataService
    {
        private readonly ILog log = LogManager.GetLogger(typeof(DownloadDataService));


        /// <summary>
        /// 下载本地数据库所有表格信息
        /// </summary>
        public void DownloadData(DownloadData p)
        {
            Stopwatch a = new Stopwatch();
            a.Start();
            DownloadUserData();
            a.Stop();
            p.AppendMessage("下载分店用户信息成功,耗时："+ a.ElapsedMilliseconds+"毫秒 \n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadRoleData();
            a.Stop();
            p.AppendMessage("下载角色信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒 \n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcProviderInfoData();
            a.Stop();
            p.AppendMessage("下载供应商数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcUserInfoData();
            a.Stop();
            p.AppendMessage("下载用户信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcOrderTransitData();
            a.Stop();
            p.AppendMessage("下载订单数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcOrderTransitItemData();
            a.Stop();
            p.AppendMessage("下载订单明细数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcClassifyData();
            a.Stop();
            p.AppendMessage("下载商品分类信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcGoodsMasterData();
            a.Stop();
            p.AppendMessage("下载商品数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcBranchTotalData();
            a.Stop();
            p.AppendMessage("下载分店数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadRelUserRoleData();
            a.Stop();
            p.AppendMessage("下载用户分店关系数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcZoningData();
            a.Stop();
            p.AppendMessage("下载区域地址数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcBranchInfoData();
            a.Stop();
            p.AppendMessage("下载仓库数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            DownloadZcStoreHouseData();
            a.Stop();
            p.AppendMessage("下载库存数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();

            ///新增下载  date 2016-1-7 11:25
            DownloadZcAssociatorInfoData();
            a.Stop();
            p.AppendMessage("下载会员表数据成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();
            ///新增下载 date 2016-1-26 16:47
            DownloadZcOrderSorteData();
            a.Stop();
            p.AppendMessage("下载配送数据信息成功,耗时：" + a.ElapsedMilliseconds + "毫秒\n");
            a.Reset();
            p.Step();
            a.Start();

            p.Close();
        }

        /// <summary>
        /// 下载用户表信息
        /// </summary>
         void DownloadUserData() 
        {
            BranchUserService branchUserService = new BranchUserService();
            branchUserService.DeleteAll();
            //从远处服务端获取User信息
            UserService userService = new UserService();
            List<User> list = userService.FindAll();
            branchUserService.AddUser(list);
        }

        /// <summary>
        /// 下载角色表信息
        /// </summary>
         void DownloadRoleData()
        {
             BranchRoleService branchRoleService = new BranchRoleService();
             branchRoleService.DeleteAll();
             RoleService roleService = new RoleService();
             List<Role> list = roleService.FindAll();
             branchRoleService.AddRole(list);
        }

        /// <summary>
        /// 下载ctp_rel_user_role数据
        /// </summary>
         void DownloadRelUserRoleData()
         {
             BranchRelUserRoleService branchRelUserRoleService = new BranchRelUserRoleService();
             branchRelUserRoleService.DeleteAll();
             RelUserRoleService relUserRoleService = new RelUserRoleService();
             List<RelUserRole> list = relUserRoleService.FindAll();
             branchRelUserRoleService.AddRelUserRole(list);
         }

        /// <summary>
        /// 下载zc_user_info数据
        /// </summary>
         void DownloadZcUserInfoData()
         {
             BranchZcUserInfoService branchZcUserInfoService = new BranchZcUserInfoService();
             branchZcUserInfoService.DeleteAll();
             ZcUserInfoService service = new ZcUserInfoService();
             List<ZcUserInfo> list = service.FindAll();
             branchZcUserInfoService.AddZcUserInfo(list);
         }

        /// <summary>
        /// 下载zc_order_transit数据
        /// </summary>
         void DownloadZcOrderTransitData()
         {
             BranchZcOrderTransitService branchService = new BranchZcOrderTransitService();
             //branchService.DeleteAll();
             ZcOrderTransitService service = new ZcOrderTransitService();
             List<ZcOrderTransit> list = service.FindAll();
             branchService.AddZcOrderTransit(list);
         }

         /// <summary>
         /// 下载zc_order_transit_item数据
         /// </summary>
         void DownloadZcOrderTransitItemData()
         {
             BranchZcOrderTransitItemService branchService = new BranchZcOrderTransitItemService();
             //branchService.DeleteAll();
             ZcOrderTransitItemService service = new ZcOrderTransitItemService();
             List<ZcOrderTransitItem> list = service.FindAll();
             branchService.AddZcOrderTransitItem(list);
         }

        /// <summary>
         /// 下载zc_classify_info数据
        /// </summary>
         void DownloadZcClassifyData()
         {
             BranchZcClassifyInfoService branchService = new BranchZcClassifyInfoService();
             branchService.DeleteAll();
             ZcClassifyInfoService service = new ZcClassifyInfoService();
             List<ZcClassIfyInfo> list = service.FindAll();
             branchService.AddZcClassifyInfo(list);
         }

        /// <summary>
        /// 下载zc_goods_master数据
        /// </summary>
         void DownloadZcGoodsMasterData() 
         {
             Stopwatch a = new Stopwatch();
             a.Start();
             BranchZcGoodsMasterService branchService = new BranchZcGoodsMasterService();
             branchService.DeleteAll();
             a.Stop();
             log.Info("删除zc_goods_master耗时 ： " + a.ElapsedMilliseconds);
             a.Reset();
             a.Start();
             ZcGoodsMasterService service = new ZcGoodsMasterService();
             List<ZcGoodsMaster> list = service.FindAll();
             a.Stop();
             log.Info("从oracle 查询zc_goods_master耗时 ： " + a.ElapsedMilliseconds);
             a.Reset();
             a.Start();
             branchService.AddZcGoodsMaster(list);
             a.Stop();
             log.Info("下载zc_goods_master耗时 ： " + a.ElapsedMilliseconds);
         }

        /// <summary>
        /// 下载zc_branch_total数据
        /// </summary>
        /// <param name="count"></param>
         void DownloadZcBranchTotalData()
         {
             BranchZcBranchTotalService branchService = new BranchZcBranchTotalService();
             branchService.DeleteAll();
             ZcBranchTotalService service = new ZcBranchTotalService();
             List<ZcBranchTotal> list = service.FindAll();
             branchService.AddZcBranchTotal(list);
         }

        /// <summary>
        /// 下载zc_zoning
        /// </summary>
        /// <param name="count"></param>
         void DownloadZcZoningData()
         {
             BranchZcZoningService branchService = new BranchZcZoningService();
             //branchService.DeleteAll();
             ZcZoningService service = new ZcZoningService();
             //List<ZcZoning> list = service.FindAll();
             List<ZcZoning> list = service.FindUpdate();
             branchService.DeleteBy(list);
             branchService.AddZcZoning(list);
         }

        /// <summary>
        /// 下载zc_provider_info
        /// </summary>
        /// <param name="count"></param>
         void DownloadZcProviderInfoData()
         {
             BranchZcProviderInfoService branchService = new BranchZcProviderInfoService();
             branchService.DeleteAll();
             ZcProviderInfoService service = new ZcProviderInfoService();
             List<ZcProviderInfo> list = service.FindAll();
             branchService.AddZcProviderInfo(list);
         }

        /// <summary>
        /// 下载zc_branch_info数据
        /// </summary>
        /// <param name="count"></param>
         void DownloadZcBranchInfoData()
         {
             BranchZcBranchInfoService branchService = new BranchZcBranchInfoService();
             branchService.DeleteAll();
             ZcBranchInfoService service = new ZcBranchInfoService();
             List<ZcBranchInfo> list = service.FindAll();
             branchService.AddZcBranchInfo(list);
         }

        /// <summary>
        /// 下载zc_storeHouse数据
        /// </summary>
         void DownloadZcStoreHouseData()
         {
             BranchZcStoreHouseService branchService = new BranchZcStoreHouseService();
             branchService.DeleteAll();
             ZcStoreHouseService service = new ZcStoreHouseService();
             List<ZcStoreHouse> list = service.FindByBranchId();
             branchService.AddZcStoreHouse(list);
         }

        /// <summary>
        /// 下载zc_associator_info数据
        /// </summary>
         void DownloadZcAssociatorInfoData()
         {
             BranchAssociatorInfoService branchService = new BranchAssociatorInfoService();
             branchService.DeleteAll();
             AssociatorInfoService service = new AssociatorInfoService();
             List<AssociatorInfo> list = service.FindAll();
             branchService.AddAssociatorInfo(list);
         }

        /// <summary>
        /// 下载分拣信息表
        /// </summary>
         void DownloadZcOrderSorteData()
         {
             ZcOrderSorteService service = new ZcOrderSorteService();
             BranchZcOrderSorteService branchService = new BranchZcOrderSorteService();
             List<ZcOrderSorte> list = service.FindByStreet();
             branchService.AddZcOrderSorte(list);
         }

    }
}
