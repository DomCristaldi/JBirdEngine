﻿using UnityEngine;
using System.Collections;

namespace JBirdEngine {

	namespace RenUnity {

		[CreateAssetMenu]
		public class StoryBranch : ScriptableObject {
			
			public Branch storyBranch;
			
			public void AddDialogueObject () {
				storyBranch.AddDialogueObject();
			}

			public void AddOptionObject () {
				storyBranch.AddOptionObject();
			}
			
		}

	}

}
