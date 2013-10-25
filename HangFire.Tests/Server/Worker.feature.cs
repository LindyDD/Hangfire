﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests.Server
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class WorkerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Worker.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Worker", "", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Worker")))
            {
                HangFire.Tests.Server.WorkerFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Worker should perform a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WorkerShouldPerformAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Worker should perform a job", ((string[])(null)));
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
     testRunner.Then("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully performed job should have the Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void SuccessfullyPerformedJobShouldHaveTheSucceededState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully performed job should have the Succeeded state", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line 10
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
     testRunner.Then("its state should be Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
      testRunner.And("the job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After performing the broken job, it should have the Failed state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterPerformingTheBrokenJobItShouldHaveTheFailedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After performing the broken job, it should have the Failed state", ((string[])(null)));
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
    testRunner.Given("an enqueued broken job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
     testRunner.Then("its state should be Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
      testRunner.And("the job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("An unexisting job should not be processed, but it should be removed from the dequ" +
            "eued list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AnUnexistingJobShouldNotBeProcessedButItShouldBeRemovedFromTheDequeuedList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An unexisting job should not be processed, but it should be removed from the dequ" +
                    "eued list", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
    testRunner.Given("the \'unexisting\' job, that was enqueued", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
     testRunner.Then("there should be no performing actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
      testRunner.But("the \'unexisting\' job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Worker should processes only jobs in the Enqueued state, but it should remove the" +
            " job from the dequeued list anyway")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WorkerShouldProcessesOnlyJobsInTheEnqueuedStateButItShouldRemoveTheJobFromTheDequeuedListAnyway()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Worker should processes only jobs in the Enqueued state, but it should remove the" +
                    " job from the dequeued list anyway", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
      testRunner.And("its state is Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
     testRunner.Then("the job should not be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
      testRunner.But("it should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Disposable job should be disposed after processing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Worker")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void DisposableJobShouldBeDisposedAfterProcessing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Disposable job should be disposed after processing", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
     testRunner.When("the worker processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
     testRunner.Then("the job should be disposed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion