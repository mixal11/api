// Copyright (C) 2014 dot42
//
// Original filename: ProgressChangedEventArgs.cs
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System;

namespace Android.Widget
{
	public class ProgressChangedEventArgs : EventArgs
	{
	    private readonly int progress;
	    private readonly bool fromUser;

	    public ProgressChangedEventArgs(int progress, bool fromUser)
	    {
	        this.progress = progress;
	        this.fromUser = fromUser;
	    }

        /// <summary>
        /// The current progress level (0..max)
        /// </summary>
	    public int Progress
	    {
	        get { return progress; }
	    }

        /// <summary>
        /// Was this change initiated by the user?
        /// </summary>
	    public bool FromUser
	    {
            get { return fromUser; }
	    }
	}
}

