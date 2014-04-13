﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapQuestObject.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Abstract base class for Bing Maps objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    /// <summary>
    /// Abstract base class for Bing Maps objects.
    /// </summary>
    public abstract class MapQuestObject
    {
        /// <summary>
        /// Gets the JavaScript type name.
        /// </summary>
        internal virtual string JavascriptTypeName
        {
            get
            {
                return string.Format("MQA.{0}", this.GetType().Name);
            }
        }

        /// <summary>
        /// Returns the JavaScript representation of the object.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        internal virtual string ToJavascript()
        {
            return string.Format("new {0}({1})", this.JavascriptTypeName, this);
        }
    }
}
