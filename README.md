# UniJsonTestRunnerApi

TestRunnerApi の情報を JSON に変換できるようにするパッケージ

## 使用例

```cs
using Kogane;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

public class Callbacks : ICallbacks
{
    public void TestStarted( ITestAdaptor test )
    {
        // JSON 形式で ITestAdaptor の情報をログ出力
        Debug.Log( new JsonITestAdaptor( test ) );
    }

    public void RunStarted( ITestAdaptor testsToRun )
    {
        // JSON 形式で ITestAdaptor の情報をログ出力
        Debug.Log( new JsonITestAdaptor( testsToRun ) );
    }

    public void RunFinished( ITestResultAdaptor result )
    {
        // JSON 形式で ITestResultAdaptor の情報をログ出力
        Debug.Log( new JsonITestResultAdaptor( result ) );
    }

    public void TestFinished( ITestResultAdaptor result )
    {
        // JSON 形式で ITestResultAdaptor の情報をログ出力
        Debug.Log( new JsonITestResultAdaptor( result ) );
    }
}

public class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        var callback      = new Callbacks();
        var testRunnerApi = ScriptableObject.CreateInstance<TestRunnerApi>();

        testRunnerApi.RegisterCallbacks( callback );

        var filter = new Filter
        {
            testMode = TestMode.EditMode,
        };

        testRunnerApi.Execute( new ExecutionSettings( filter ) );

        testRunnerApi.UnregisterCallbacks( callback );
    }
}
```
