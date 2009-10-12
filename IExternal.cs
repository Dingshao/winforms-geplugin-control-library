﻿// <copyright file="IExternal.cs" company="FC">
// Copyright (c) 2008 Fraser Chapman
// </copyright>
// <author>Fraser Chapman</author>
// <email>fraser.chapman@gmail.com</email>
// <date>2009-10-04</date>
// <summary>This file is part of FC.GEPluginCtrls
// FC.GEPluginCtrls is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program. If not, see http://www.gnu.org/licenses/.
// </summary>
namespace FC.GEPluginCtrls
{
    using GEPlugin;

    /// <summary>
    /// This interface should be implemented by any object
    /// that is designed to act as the interface between javascript and managed code
    /// </summary>
    public interface IExternal
    {
        /// <summary>
        /// Raised when the plugin is ready
        /// </summary>
        event ExternalEventHandeler PluginReady;

        /// <summary>
        /// Raised when there is a kml event
        /// </summary>
        event ExternalEventHandeler KmlEvent;

        /// <summary>
        /// Raised when a kml/kmz file has loaded
        /// </summary>
        event ExternalEventHandeler KmlLoaded;

        /// <summary>
        /// Raised when there is a script error in the document 
        /// </summary>
        event ExternalEventHandeler ScriptError;

        /// <summary>
        /// Should be called from javascript when a kml/kmz file has been loaded
        /// </summary>
        /// <param name="kmlObject">the loaded kml object</param>
        void LoadKmlCallBack(IKmlObject kmlObject);

        /// <summary>
        /// Should be called from javascript when the plugin is ready
        /// </summary>
        /// <param name="ge">the plugin instance</param>
        void Ready(IGEPlugin ge);

        /// <summary>
        /// Should be called from javascript when there is an error
        /// </summary>
        /// <param name="message">the error message</param>
        void Error(string message);

        /// <summary>
        /// Should be called from javascript when there is a kml event
        /// </summary>
        /// <param name="kmlEvent">the kml event</param>
        /// <param name="action">the event id</param>
        void KmlEventCallBack(IKmlEvent kmlEvent, string action);
    }
}
