using System;
using System.Collections.Generic;
using System.Text;
using Extensions;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
	/// <summary>
	/// Retrieves information about an Eve Window.
	/// </summary>
	public class EVEWindow : LavishScriptObject
	{
		#region Constructors
		/// <summary>
		/// EVEWindow copy constructor.
		/// </summary>
		/// <param name="Obj"></param>
		public EVEWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		/// <summary>
		/// Possible "Names" include: "MyShipCargo", "MyDroneBay", "Market", "hangarFloor", 
		/// "shipHangar", "Local", "Corporation Hangar" (more added as needed/requested).
		/// </summary>
		public EVEWindow(string name)
			: base(LavishScript.Objects.GetObject("EVEWindow", name))
		{
		}
		#endregion

		#region Statics
		/// <summary>
		/// should only be used for windows not available otherwise (ie, cargo containers).
		/// </summary>
		public static EVEWindow GetWindowByCaption(string caption)
		{
			return new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", "ByCaption", caption));
		}

		/// <summary>
		/// Returns an evewindow type based on a window name.
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static EVEWindow GetWindowByName(string name)
		{
			return new EVEWindow(LavishScript.Objects.GetObject("EVEWindow", name));
		}
		#endregion

		#region Members
		/// <summary>
		/// Wrapper for the Caption member of the evewindow type.
		/// </summary>
		public string Caption
		{
			get { return this.GetStringFromLSO("Caption"); }
		}

		/// <summary>
		/// Wrapper for the Minimized member of the evewindow type.
		/// </summary>
		public bool Minimized
		{
			get { return this.GetBoolFromLSO("Minimized"); }
		}

		/// <summary>
		/// Wrapper for the HTML member of the evewindow type.
		/// </summary>
		public string HTML
		{
			get { return this.GetStringFromLSO("HTML"); }
		}

	    public string Text
	    {
			get { return this.GetStringFromLSO("Text"); }
	    }

        /// <summary>
        /// The ID of the ship or other object that this window belongs to, i.e. EVEWindow[MyShipCargo].ItemID will be your ship ID
        /// </summary>
	    public Int64 ItemID
	    {
            get { return this.GetInt64FromLSO("ItemID"); }
	    }
		#endregion

		#region Methods
		/// <summary>
		/// Wrapper for the Close method of the evewindow type.
		/// </summary>
		/// <returns></returns>
		public bool Close()
		{
			Tracing.SendCallback("EVEWindow.Close");
			return ExecuteMethod("Close");
		}

		/// <summary>
		/// Wrapper for the Maximize method of the evewindow type.
		/// </summary>
		/// <returns></returns>
		public bool Maximize()
		{
			Tracing.SendCallback("EVEWindow.Maximize");
			return ExecuteMethod("Maximize");
		}

		/// <summary>
		/// Wrapper for the Minimize method of the evewindow type.
		/// </summary>
		/// <returns></returns>
		public bool Minimize()
		{
			Tracing.SendCallback("EVEWindow.Minimize");
			return ExecuteMethod("Minimize");
		}

        public bool ClickButtonYes()
        {
            Tracing.SendCallback("EVEWindow.ClickButtonYes");
            return ExecuteMethod("ClickButtonYes");
        }

        public bool ClickButtonNo()
        {
            Tracing.SendCallback("EVEWindow.ClickButtonNo");
            return ExecuteMethod("ClickButtonNo");
        }

        public bool ClickButtonOK()
        {
            Tracing.SendCallback("EVEWindow.ClickButtonOK");
            return ExecuteMethod("ClickButtonOK");
        }

        public bool ClickButtonCancel()
        {
            Tracing.SendCallback("EVEWindow.ClickButtonCancel");
            return ExecuteMethod("ClickButtonCancel");
        }

        public bool ClickButtonClose()
        {
            Tracing.SendCallback("EVEWindow.ClickButtonClose");
            return ExecuteMethod("ClickButtonClose");
        }
		#endregion
	}
}
