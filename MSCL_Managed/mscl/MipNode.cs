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

public class MipNode : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MipNode(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MipNode obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MipNode() {
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
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse, byte responseDataDescriptor) {
    Bytes ret = new Bytes(msclPINVOKE.MipNode_doCommand__SWIG_0(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse, responseDataDescriptor), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Bytes doCommand(byte descriptorSet, byte cmdDescriptor, Bytes fieldData, bool ackNackResponse, bool dataResponse) {
    Bytes ret = new Bytes(msclPINVOKE.MipNode_doCommand__SWIG_1(swigCPtr, descriptorSet, cmdDescriptor, Bytes.getCPtr(fieldData), ackNackResponse, dataResponse), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipCommandSet getConfigCommandBytes() {
    MipCommandSet ret = new MipCommandSet(msclPINVOKE.MipNode_getConfigCommandBytes(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void sendCommandBytes(MipCommandSet cmds) {
    msclPINVOKE.MipNode_sendCommandBytes__SWIG_0(swigCPtr, MipCommandSet.getCPtr(cmds));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void sendCommandBytes(MipCommandBytes cmd) {
    msclPINVOKE.MipNode_sendCommandBytes__SWIG_1(swigCPtr, MipCommandBytes.getCPtr(cmd));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string deviceName(string serial) {
    string ret = msclPINVOKE.MipNode_deviceName(serial);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Connection connection() {
    Connection ret = new Connection(msclPINVOKE.MipNode_connection(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipNodeFeatures features() {
    MipNodeFeatures ret = new MipNodeFeatures(msclPINVOKE.MipNode_features(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void clearDeviceInfo() {
    msclPINVOKE.MipNode_clearDeviceInfo(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public Timestamp lastCommunicationTime() {
    Timestamp ret = new Timestamp(msclPINVOKE.MipNode_lastCommunicationTime(swigCPtr), false);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public DeviceState lastDeviceState() {
    DeviceState ret = (DeviceState)msclPINVOKE.MipNode_lastDeviceState(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Version firmwareVersion() {
    Version ret = new Version(msclPINVOKE.MipNode_firmwareVersion(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MipModels.NodeModel model() {
    MipModels.NodeModel ret = (MipModels.NodeModel)msclPINVOKE.MipNode_model(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelName() {
    string ret = msclPINVOKE.MipNode_modelName(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string modelNumber() {
    string ret = msclPINVOKE.MipNode_modelNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string serialNumber() {
    string ret = msclPINVOKE.MipNode_serialNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string lotNumber() {
    string ret = msclPINVOKE.MipNode_lotNumber(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string deviceOptions() {
    string ret = msclPINVOKE.MipNode_deviceOptions(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void timeout(ulong timeout) {
    msclPINVOKE.MipNode_timeout__SWIG_0(swigCPtr, timeout);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public ulong timeout() {
    ulong ret = msclPINVOKE.MipNode_timeout__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string name() {
    string ret = msclPINVOKE.MipNode_name(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ping() {
    bool ret = msclPINVOKE.MipNode_ping(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void setToIdle() {
    msclPINVOKE.MipNode_setToIdle(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool cyclePower() {
    bool ret = msclPINVOKE.MipNode_cyclePower(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void resume() {
    msclPINVOKE.MipNode_resume(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual byte getCommunicationMode() {
    byte ret = msclPINVOKE.MipNode_getCommunicationMode(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setCommunicationMode(byte communicationMode) {
    msclPINVOKE.MipNode_setCommunicationMode(swigCPtr, communicationMode);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void saveSettingsAsStartup() {
    msclPINVOKE.MipNode_saveSettingsAsStartup__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void saveSettingsAsStartup(MipCommands cmdIds) {
    msclPINVOKE.MipNode_saveSettingsAsStartup__SWIG_1(swigCPtr, MipCommands.getCPtr(cmdIds));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void saveSettingsAsStartup(MipCommandParameters cmdParams) {
    msclPINVOKE.MipNode_saveSettingsAsStartup__SWIG_2(swigCPtr, MipCommandParameters.getCPtr(cmdParams));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadStartupSettings() {
    msclPINVOKE.MipNode_loadStartupSettings__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadStartupSettings(MipCommands cmdIds) {
    msclPINVOKE.MipNode_loadStartupSettings__SWIG_1(swigCPtr, MipCommands.getCPtr(cmdIds));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadStartupSettings(MipCommandParameters cmdParams) {
    msclPINVOKE.MipNode_loadStartupSettings__SWIG_2(swigCPtr, MipCommandParameters.getCPtr(cmdParams));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFactoryDefaultSettings() {
    msclPINVOKE.MipNode_loadFactoryDefaultSettings__SWIG_0(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFactoryDefaultSettings(MipCommands cmdIds) {
    msclPINVOKE.MipNode_loadFactoryDefaultSettings__SWIG_1(swigCPtr, MipCommands.getCPtr(cmdIds));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void loadFactoryDefaultSettings(MipCommandParameters cmdParams) {
    msclPINVOKE.MipNode_loadFactoryDefaultSettings__SWIG_2(swigCPtr, MipCommandParameters.getCPtr(cmdParams));
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setUARTBaudRate(uint baudRate, bool resetConnection) {
    msclPINVOKE.MipNode_setUARTBaudRate__SWIG_0(swigCPtr, baudRate, resetConnection);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setUARTBaudRate(uint baudRate) {
    msclPINVOKE.MipNode_setUARTBaudRate__SWIG_1(swigCPtr, baudRate);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setUARTBaudRate(uint baudRate, byte portId, bool resetConnection) {
    msclPINVOKE.MipNode_setUARTBaudRate__SWIG_2(swigCPtr, baudRate, portId, resetConnection);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setUARTBaudRate(uint baudRate, byte portId) {
    msclPINVOKE.MipNode_setUARTBaudRate__SWIG_3(swigCPtr, baudRate, portId);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint getUARTBaudRate(byte portId) {
    uint ret = msclPINVOKE.MipNode_getUARTBaudRate__SWIG_0(swigCPtr, portId);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public uint getUARTBaudRate() {
    uint ret = msclPINVOKE.MipNode_getUARTBaudRate__SWIG_1(swigCPtr);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RawBytePackets getRawBytePackets(uint timeout, uint maxPackets) {
    RawBytePackets ret = new RawBytePackets(msclPINVOKE.MipNode_getRawBytePackets__SWIG_0(swigCPtr, timeout, maxPackets), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RawBytePackets getRawBytePackets(uint timeout) {
    RawBytePackets ret = new RawBytePackets(msclPINVOKE.MipNode_getRawBytePackets__SWIG_1(swigCPtr, timeout), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public RawBytePackets getRawBytePackets() {
    RawBytePackets ret = new RawBytePackets(msclPINVOKE.MipNode_getRawBytePackets__SWIG_2(swigCPtr), true);
    if (msclPINVOKE.SWIGPendingException.Pending) throw msclPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}