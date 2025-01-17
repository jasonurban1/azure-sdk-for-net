// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema for all properties of Recording Storage Information. </summary>
    public partial class AcsRecordingStorageInfoProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsRecordingStorageInfoProperties"/>. </summary>
        internal AcsRecordingStorageInfoProperties()
        {
            RecordingChunks = new ChangeTrackingList<AcsRecordingChunkInfoProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsRecordingStorageInfoProperties"/>. </summary>
        /// <param name="recordingChunks"> List of details of recording chunks information. </param>
        internal AcsRecordingStorageInfoProperties(IReadOnlyList<AcsRecordingChunkInfoProperties> recordingChunks)
        {
            RecordingChunks = recordingChunks;
        }

        /// <summary> List of details of recording chunks information. </summary>
        public IReadOnlyList<AcsRecordingChunkInfoProperties> RecordingChunks { get; }
    }
}
