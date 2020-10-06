using JetBrains.Annotations;
using System;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace Kogane
{
	[Serializable]
	public struct JsonITestAdaptor
	{
		[SerializeField][UsedImplicitly] private string   Id;
		[SerializeField][UsedImplicitly] private string   ParentUniqueName;
		[SerializeField][UsedImplicitly] private string   UniqueName;
		[SerializeField][UsedImplicitly] private string   ParentFullName;
		[SerializeField][UsedImplicitly] private string   ParentId;
		[SerializeField][UsedImplicitly] private string   SkipReason;
		[SerializeField][UsedImplicitly] private string   Description;
		[SerializeField][UsedImplicitly] private RunState RunState;
		[SerializeField][UsedImplicitly] private bool     IsTestAssembly;
		[SerializeField][UsedImplicitly] private string[] Categories;
		[SerializeField][UsedImplicitly] private int      TestCaseTimeout;
		[SerializeField][UsedImplicitly] private bool     IsSuite;
		[SerializeField][UsedImplicitly] private bool     HasChildren;
		[SerializeField][UsedImplicitly] private int      TestCaseCount;
		[SerializeField][UsedImplicitly] private string   FullName;
		[SerializeField][UsedImplicitly] private string   Name;
		[SerializeField][UsedImplicitly] private int      ChildIndex;
		[SerializeField][UsedImplicitly] private TestMode TestMode;

		public JsonITestAdaptor( ITestAdaptor other )
		{
			Id               = other.Id;
			ParentUniqueName = other.ParentUniqueName;
			UniqueName       = other.UniqueName;
			ParentFullName   = other.ParentFullName;
			ParentId         = other.ParentId;
			SkipReason       = other.SkipReason;
			Description      = other.Description;
			RunState         = other.RunState;
			IsTestAssembly   = other.IsTestAssembly;
			Categories       = other.Categories;
			TestCaseTimeout  = other.TestCaseTimeout;
			IsSuite          = other.IsSuite;
			HasChildren      = other.HasChildren;
			TestCaseCount    = other.TestCaseCount;
			FullName         = other.FullName;
			Name             = other.Name;
			ChildIndex       = other.ChildIndex;
			TestMode         = other.TestMode;
		}

		public override string ToString()
		{
			return JsonUtility.ToJson( this, true );
		}
	}
}