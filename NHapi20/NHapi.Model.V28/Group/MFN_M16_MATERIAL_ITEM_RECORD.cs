using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V28.Segment;
using NHapi.Model.V28.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V28.Group
{
///<summary>
///Represents the MFN_M16_MATERIAL_ITEM_RECORD Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: MFE (Master File Entry) </li>
///<li>1: ITM (Material Item) </li>
///<li>2: NTE (Notes and Comments) optional repeating</li>
///<li>3: MFN_M16_STERILIZATION (a Group object) optional repeating</li>
///<li>4: MFN_M16_PURCHASING_VENDOR (a Group object) optional repeating</li>
///<li>5: MFN_M16_MATERIAL_LOCATION (a Group object) optional repeating</li>
///</ol>
///</summary>
[Serializable]
public class MFN_M16_MATERIAL_ITEM_RECORD : AbstractGroup {

	///<summary> 
	/// Creates a new MFN_M16_MATERIAL_ITEM_RECORD Group.
	///</summary>
	public MFN_M16_MATERIAL_ITEM_RECORD(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(MFE), true, false);
	      this.add(typeof(ITM), true, false);
	      this.add(typeof(NTE), false, true);
	      this.add(typeof(MFN_M16_STERILIZATION), false, true);
	      this.add(typeof(MFN_M16_PURCHASING_VENDOR), false, true);
	      this.add(typeof(MFN_M16_MATERIAL_LOCATION), false, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating MFN_M16_MATERIAL_ITEM_RECORD - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns MFE (Master File Entry) - creates it if necessary
	///</summary>
	public MFE MFE { 
get{
	   MFE ret = null;
	   try {
	      ret = (MFE)this.GetStructure("MFE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns ITM (Material Item) - creates it if necessary
	///</summary>
	public ITM ITM { 
get{
	   ITM ret = null;
	   try {
	      ret = (ITM)this.GetStructure("ITM");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of NTE (Notes and Comments) - creates it if necessary
	///</summary>
	public NTE GetNTE() {
	   NTE ret = null;
	   try {
	      ret = (NTE)this.GetStructure("NTE");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of NTE
	/// * (Notes and Comments) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public NTE GetNTE(int rep) { 
	   return (NTE)this.GetStructure("NTE", rep);
	}

	/** 
	 * Returns the number of existing repetitions of NTE 
	 */ 
	public int NTERepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("NTE").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the NTE results 
	 */ 
	public IEnumerable<NTE> NTEs 
	{ 
		get
		{
			for (int rep = 0; rep < NTERepetitionsUsed; rep++)
			{
				yield return (NTE)this.GetStructure("NTE", rep);
			}
		}
	}

	///<summary>
	///Adds a new NTE
	///</summary>
	public NTE AddNTE()
	{
		return this.AddStructure("NTE") as NTE;
	}

	///<summary>
	///Removes the given NTE
	///</summary>
	public void RemoveNTE(NTE toRemove)
	{
		this.RemoveStructure("NTE", toRemove);
	}

	///<summary>
	///Removes the NTE at the given index
	///</summary>
	public void RemoveNTEAt(int index)
	{
		this.RemoveRepetition("NTE", index);
	}

	///<summary>
	/// Returns  first repetition of MFN_M16_STERILIZATION (a Group object) - creates it if necessary
	///</summary>
	public MFN_M16_STERILIZATION GetSTERILIZATION() {
	   MFN_M16_STERILIZATION ret = null;
	   try {
	      ret = (MFN_M16_STERILIZATION)this.GetStructure("STERILIZATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of MFN_M16_STERILIZATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public MFN_M16_STERILIZATION GetSTERILIZATION(int rep) { 
	   return (MFN_M16_STERILIZATION)this.GetStructure("STERILIZATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M16_STERILIZATION 
	 */ 
	public int STERILIZATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("STERILIZATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the MFN_M16_STERILIZATION results 
	 */ 
	public IEnumerable<MFN_M16_STERILIZATION> STERILIZATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < STERILIZATIONRepetitionsUsed; rep++)
			{
				yield return (MFN_M16_STERILIZATION)this.GetStructure("STERILIZATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new MFN_M16_STERILIZATION
	///</summary>
	public MFN_M16_STERILIZATION AddSTERILIZATION()
	{
		return this.AddStructure("STERILIZATION") as MFN_M16_STERILIZATION;
	}

	///<summary>
	///Removes the given MFN_M16_STERILIZATION
	///</summary>
	public void RemoveSTERILIZATION(MFN_M16_STERILIZATION toRemove)
	{
		this.RemoveStructure("STERILIZATION", toRemove);
	}

	///<summary>
	///Removes the MFN_M16_STERILIZATION at the given index
	///</summary>
	public void RemoveSTERILIZATIONAt(int index)
	{
		this.RemoveRepetition("STERILIZATION", index);
	}

	///<summary>
	/// Returns  first repetition of MFN_M16_PURCHASING_VENDOR (a Group object) - creates it if necessary
	///</summary>
	public MFN_M16_PURCHASING_VENDOR GetPURCHASING_VENDOR() {
	   MFN_M16_PURCHASING_VENDOR ret = null;
	   try {
	      ret = (MFN_M16_PURCHASING_VENDOR)this.GetStructure("PURCHASING_VENDOR");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of MFN_M16_PURCHASING_VENDOR
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public MFN_M16_PURCHASING_VENDOR GetPURCHASING_VENDOR(int rep) { 
	   return (MFN_M16_PURCHASING_VENDOR)this.GetStructure("PURCHASING_VENDOR", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M16_PURCHASING_VENDOR 
	 */ 
	public int PURCHASING_VENDORRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("PURCHASING_VENDOR").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the MFN_M16_PURCHASING_VENDOR results 
	 */ 
	public IEnumerable<MFN_M16_PURCHASING_VENDOR> PURCHASING_VENDORs 
	{ 
		get
		{
			for (int rep = 0; rep < PURCHASING_VENDORRepetitionsUsed; rep++)
			{
				yield return (MFN_M16_PURCHASING_VENDOR)this.GetStructure("PURCHASING_VENDOR", rep);
			}
		}
	}

	///<summary>
	///Adds a new MFN_M16_PURCHASING_VENDOR
	///</summary>
	public MFN_M16_PURCHASING_VENDOR AddPURCHASING_VENDOR()
	{
		return this.AddStructure("PURCHASING_VENDOR") as MFN_M16_PURCHASING_VENDOR;
	}

	///<summary>
	///Removes the given MFN_M16_PURCHASING_VENDOR
	///</summary>
	public void RemovePURCHASING_VENDOR(MFN_M16_PURCHASING_VENDOR toRemove)
	{
		this.RemoveStructure("PURCHASING_VENDOR", toRemove);
	}

	///<summary>
	///Removes the MFN_M16_PURCHASING_VENDOR at the given index
	///</summary>
	public void RemovePURCHASING_VENDORAt(int index)
	{
		this.RemoveRepetition("PURCHASING_VENDOR", index);
	}

	///<summary>
	/// Returns  first repetition of MFN_M16_MATERIAL_LOCATION (a Group object) - creates it if necessary
	///</summary>
	public MFN_M16_MATERIAL_LOCATION GetMATERIAL_LOCATION() {
	   MFN_M16_MATERIAL_LOCATION ret = null;
	   try {
	      ret = (MFN_M16_MATERIAL_LOCATION)this.GetStructure("MATERIAL_LOCATION");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of MFN_M16_MATERIAL_LOCATION
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public MFN_M16_MATERIAL_LOCATION GetMATERIAL_LOCATION(int rep) { 
	   return (MFN_M16_MATERIAL_LOCATION)this.GetStructure("MATERIAL_LOCATION", rep);
	}

	/** 
	 * Returns the number of existing repetitions of MFN_M16_MATERIAL_LOCATION 
	 */ 
	public int MATERIAL_LOCATIONRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("MATERIAL_LOCATION").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the MFN_M16_MATERIAL_LOCATION results 
	 */ 
	public IEnumerable<MFN_M16_MATERIAL_LOCATION> MATERIAL_LOCATIONs 
	{ 
		get
		{
			for (int rep = 0; rep < MATERIAL_LOCATIONRepetitionsUsed; rep++)
			{
				yield return (MFN_M16_MATERIAL_LOCATION)this.GetStructure("MATERIAL_LOCATION", rep);
			}
		}
	}

	///<summary>
	///Adds a new MFN_M16_MATERIAL_LOCATION
	///</summary>
	public MFN_M16_MATERIAL_LOCATION AddMATERIAL_LOCATION()
	{
		return this.AddStructure("MATERIAL_LOCATION") as MFN_M16_MATERIAL_LOCATION;
	}

	///<summary>
	///Removes the given MFN_M16_MATERIAL_LOCATION
	///</summary>
	public void RemoveMATERIAL_LOCATION(MFN_M16_MATERIAL_LOCATION toRemove)
	{
		this.RemoveStructure("MATERIAL_LOCATION", toRemove);
	}

	///<summary>
	///Removes the MFN_M16_MATERIAL_LOCATION at the given index
	///</summary>
	public void RemoveMATERIAL_LOCATIONAt(int index)
	{
		this.RemoveRepetition("MATERIAL_LOCATION", index);
	}

}
}
