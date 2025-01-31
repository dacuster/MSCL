//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace mscl {

public class WirelessModels : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal WirelessModels(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(WirelessModels obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~WirelessModels() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          msclPINVOKE.delete_WirelessModels(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public WirelessModels() : this(msclPINVOKE.new_WirelessModels(), true) {
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum NodeModel {
    node_vLink_legacy = 2428,
    node_cfBearingTempLink = 51280096,
    node_envLink_pro = 60000001,
    node_gLink_2g = 63052000,
    node_gLink_10g = 63053000,
    node_gLinkII_cust_in = 63054000,
    node_gLinkII_2g_in = 63054002,
    node_gLinkII_10g_in = 63054010,
    node_gLinkII_cust_ex = 63055000,
    node_gLinkII_2g_ex = 63055002,
    node_gLinkII_10g_ex = 63055010,
    node_gLink_rgd_10g = 63056010,
    node_gLink_200_8g = 63056000,
    node_gLink_200_40g = 63056001,
    node_gLink_200_8g_oem = 63056002,
    node_gLink_200_40g_oem = 63056003,
    node_gLink_200_8g_oem_mmcx = 63056181,
    node_gLink_200_40g_oem_mmcx = 63056141,
    node_gLink_200_8g_oem_u_fl = 63056182,
    node_gLink_200_40g_oem_u_fl = 63056142,
    node_gLink_200_r = 63056200,
    node_sgLink_oem_S = 63081000,
    node_sgLink = 63083000,
    node_sgLink200 = 63083300,
    node_sgLink200_hbridge_1K = 63083310,
    node_sgLink200_hbridge_350 = 63083330,
    node_sgLink200_hbridge_120 = 63083320,
    node_sgLink200_qbridge_1K = 63083410,
    node_sgLink200_qbridge_350 = 63083430,
    node_sgLink200_qbridge_120 = 63083420,
    node_sgLink_oem = 63084000,
    node_sgLink_micro = 63084100,
    node_sgLink200_oem = 63084200,
    node_sgLink200_oem_ufl = 63084201,
    node_sgLink200_oem_hbridge_1K = 63084310,
    node_sgLink200_oem_hbridge_1K_ufl = 63084311,
    node_sgLink200_oem_hbridge_120 = 63084320,
    node_sgLink200_oem_hbridge_120_ufl = 63084321,
    node_sgLink200_oem_hbridge_350 = 63084330,
    node_sgLink200_oem_hbridge_350_ufl = 63084331,
    node_sgLink200_oem_qbridge_1K = 63084410,
    node_sgLink200_oem_qbridge_1K_ufl = 63084411,
    node_sgLink200_oem_qbridge_120 = 63084420,
    node_sgLink200_oem_qbridge_120_ufl = 63084421,
    node_sgLink200_oem_qbridge_350 = 63084430,
    node_sgLink200_oem_qbridge_350_ufl = 63084431,
    node_sgLink_rgd = 63085000,
    node_shmLink = 63086000,
    node_tcLink_1ch = 63104000,
    node_tcLink_6ch = 63105000,
    node_tcLink_3ch = 63106000,
    node_tcLink_6ch_ip67 = 63107000,
    node_tcLink200_oem = 63104100,
    node_tcLink200_oem_ufl = 63104101,
    node_tcLink200 = 63105400,
    node_rtdLink200 = 63105500,
    node_tcLink_6ch_ip67_rht = 63108000,
    node_vLink = 63121000,
    node_vLink200 = 63122000,
    node_vLink200_qbridge_1K = 63122110,
    node_vLink200_qbridge_120 = 63122120,
    node_vLink200_qbridge_350 = 63122130,
    node_vLink200_hbridge_1K = 63122210,
    node_vLink200_hbridge_120 = 63122220,
    node_vLink200_hbridge_350 = 63122230,
    node_iepeLink = 63160010,
    node_dvrtLink = 63181000,
    node_envLink_mini = 63220000,
    node_wattLink = 63230000,
    node_wattLink_3Y208 = 63231100,
    node_wattLink_3D240 = 63232200,
    node_wattLink_3Y400 = 63233100,
    node_wattLink_3D400 = 63233200,
    node_wattLink_3Y480 = 63234100,
    node_wattLink_3D480 = 63234200,
    node_wattLink_3Y600 = 63235100,
    node_ptLink200 = 63250200,
    node_rtdLink = 63260000,
    node_shmLink2_cust1_oldNumber = 63290000,
    node_shmLink2_cust1 = 63290100,
    node_shmLink200 = 63290200,
    node_shmLink201 = 63290150,
    node_shmLink201_qbridge_1K = 63290151,
    node_shmLink201_qbridge_348 = 63290152,
    node_shmLink201_hbridge_1K = 63290153,
    node_shmLink201_hbridge_348 = 63290154,
    node_shmLink201_fullbridge = 63290155,
    node_shmLink210_fullbridge = 63290170,
    node_shmLink210_qbridge_3K = 63290171,
    node_torqueLink = 63309999,
    node_torqueLink200_3ch = 63313000,
    node_torqueLink200 = 63319999,
    node_torqueLink200_3ch_s = 63323350,
    node_sgLink_herm = 65010000,
    node_sgLink_herm_2600 = 65011110,
    node_sgLink_herm_2700 = 65011210,
    node_sgLink_herm_2800 = 65011310,
    node_sgLink_herm_2900 = 65011410,
    node_wirelessImpactSensor = 65080000,
    node_gLink_200_40g_s = 65226001
  }

  public enum BaseModel {
    base_wsda_1000 = 63140050,
    base_wsda_1500 = 63141500,
    base_wsda_2000 = 63142000,
    base_wsdaBase_200_legacy = 63070200,
    base_wsdaBase_200 = 63072040,
    base_wsdaBase_200_extAntenna = 63072140,
    base_wsdaBase_101_analog = 63071010,
    base_wsdaBase_102_rs232 = 63071020,
    base_wsdaBase_104_usb = 63071040,
    base_wsi_104 = 63072000,
    base_wsdaBase_mini = 63079999
  }

}

}
