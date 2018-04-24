﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace VideoUploader.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class PathfinderVideo
    {
        /// <summary>
        /// Initializes a new instance of the PathfinderVideo class.
        /// </summary>
        public PathfinderVideo() { }

        /// <summary>
        /// Initializes a new instance of the PathfinderVideo class.
        /// </summary>
        public PathfinderVideo(string patientID = default(string), string startTime = default(string), string endTime = default(string), string fileName = default(string))
        {
            PatientID = patientID;
            StartTime = startTime;
            EndTime = endTime;
            FileName = fileName;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PatientID")]
        public string PatientID { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "FileName")]
        public string FileName { get; set; }

    }
}
