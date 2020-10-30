
using System;
namespace BMS.Model
{
	public class AndonModel : BaseModel
	{
		private int iD;
		private int shiftID;
		private DateTime? shiftStartTime;
		private DateTime? shiftEndTime;
		private int totalSeconds;
		private DateTime? dateLR;
		private int takt;
		private int qtyPlanDay;
		private int qtyPlanCurrent;
		private int qtyActual;
		private int qtyDelay;
		public int ID
		{
			get { return iD; }
			set { iD = value; }
		}
	
		public int ShiftID
		{
			get { return shiftID; }
			set { shiftID = value; }
		}
	
		public DateTime? ShiftStartTime
		{
			get { return shiftStartTime; }
			set { shiftStartTime = value; }
		}
	
		public DateTime? ShiftEndTime
		{
			get { return shiftEndTime; }
			set { shiftEndTime = value; }
		}
	
		public int TotalSeconds
		{
			get { return totalSeconds; }
			set { totalSeconds = value; }
		}
	
		public DateTime? DateLR
		{
			get { return dateLR; }
			set { dateLR = value; }
		}
	
		public int Takt
		{
			get { return takt; }
			set { takt = value; }
		}
	
		public int QtyPlanDay
		{
			get { return qtyPlanDay; }
			set { qtyPlanDay = value; }
		}
	
		public int QtyPlanCurrent
		{
			get { return qtyPlanCurrent; }
			set { qtyPlanCurrent = value; }
		}
	
		public int QtyActual
		{
			get { return qtyActual; }
			set { qtyActual = value; }
		}
	
		public int QtyDelay
		{
			get { return qtyDelay; }
			set { qtyDelay = value; }
		}
	
	}
}
	