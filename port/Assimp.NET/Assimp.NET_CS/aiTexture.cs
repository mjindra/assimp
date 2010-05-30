/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiTexture : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiTexture(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiTexture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiTexture() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiTexture(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public uint mWidth {
    set {
      Assimp_NETPINVOKE.aiTexture_mWidth_set(swigCPtr, value);
    } 
    get {
      uint ret = Assimp_NETPINVOKE.aiTexture_mWidth_get(swigCPtr);
      return ret;
    } 
  }

  public uint mHeight {
    set {
      Assimp_NETPINVOKE.aiTexture_mHeight_set(swigCPtr, value);
    } 
    get {
      uint ret = Assimp_NETPINVOKE.aiTexture_mHeight_get(swigCPtr);
      return ret;
    } 
  }

  public string achFormatHint {
    set {
      Assimp_NETPINVOKE.aiTexture_achFormatHint_set(swigCPtr, value);
    } 
    get {
      string ret = Assimp_NETPINVOKE.aiTexture_achFormatHint_get(swigCPtr);
      return ret;
    } 
  }

  public aiTexel pcData {
    set {
      Assimp_NETPINVOKE.aiTexture_pcData_set(swigCPtr, aiTexel.getCPtr(value));
    } 
    get {
      IntPtr cPtr = Assimp_NETPINVOKE.aiTexture_pcData_get(swigCPtr);
      aiTexel ret = (cPtr == IntPtr.Zero) ? null : new aiTexel(cPtr, false);
      return ret;
    } 
  }

  public bool CheckFormat(string s) {
    bool ret = Assimp_NETPINVOKE.aiTexture_CheckFormat(swigCPtr, s);
    return ret;
  }

  public aiTexture() : this(Assimp_NETPINVOKE.new_aiTexture(), true) {
  }

}