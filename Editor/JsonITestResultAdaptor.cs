using JetBrains.Annotations;
using System;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;
using TestStatus = UnityEditor.TestTools.TestRunner.Api.TestStatus;

namespace Kogane
{
	[Serializable]
	public struct JsonITestResultAdaptor
	{
		[SerializeField][UsedImplicitly] private string       Message;
		[SerializeField][UsedImplicitly] private bool         HasChildren;
		[SerializeField][UsedImplicitly] private int          InconclusiveCount;
		[SerializeField][UsedImplicitly] private int          SkipCount;
		[SerializeField][UsedImplicitly] private int          PassCount;
		[SerializeField][UsedImplicitly] private int          FailCount;
		[SerializeField][UsedImplicitly] private int          AssertCount;
		[SerializeField][UsedImplicitly] private string       StackTrace;
		[SerializeField][UsedImplicitly] private string       Output;
		[SerializeField][UsedImplicitly] private string       StartTime;
		[SerializeField][UsedImplicitly] private double       Duration;
		[SerializeField][UsedImplicitly] private TestStatus   TestStatus;
		[SerializeField][UsedImplicitly] private string       ResultState;
		[SerializeField][UsedImplicitly] private string       FullName;
		[SerializeField][UsedImplicitly] private string       Name;
		[SerializeField][UsedImplicitly] private ITestAdaptor Test;
		[SerializeField][UsedImplicitly] private string       EndTime;

		public JsonITestResultAdaptor( ITestResultAdaptor other )
		{
			var jstZoneInfo = TimeZoneInfo.Local;

			Message           = other.Message;
			HasChildren       = other.HasChildren;
			InconclusiveCount = other.InconclusiveCount;
			SkipCount         = other.SkipCount;
			PassCount         = other.PassCount;
			FailCount         = other.FailCount;
			AssertCount       = other.AssertCount;
			StackTrace        = other.StackTrace;
			Output            = other.Output;
			StartTime         = TimeZoneInfo.ConvertTimeFromUtc( other.StartTime, jstZoneInfo ).ToString( "yyyy/MM/dd HH:mm:ss" );
			Duration          = other.Duration;
			TestStatus        = other.TestStatus;
			ResultState       = other.ResultState;
			FullName          = other.FullName;
			Name              = other.Name;
			Test              = other.Test;
			EndTime           = TimeZoneInfo.ConvertTimeFromUtc( other.EndTime, jstZoneInfo ).ToString( "yyyy/MM/dd HH:mm:ss" );
		}

		public override string ToString()
		{
			return JsonUtility.ToJson( this, true );
		}
	}
}