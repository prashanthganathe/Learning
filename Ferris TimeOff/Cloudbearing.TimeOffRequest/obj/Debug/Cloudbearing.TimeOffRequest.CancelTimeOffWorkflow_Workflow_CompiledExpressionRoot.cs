namespace Cloudbearing.TimeOffRequest.CancelTimeOffWorkflow {
    
    #line 17 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 18 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 19 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 20 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "E:\SharepointApps\Ferris TimeOff\Cloudbearing.TimeOffRequest\CancelTimeOffWorkflow\Workflow.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow_TypedDataContext2.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext0 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext0.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext1 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext2 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext3 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext4 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext4.GetLocation<System.DateTime>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext5 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext6 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext6.GetLocation<string>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext7 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext8 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext8.GetLocation<System.DateTime>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext9 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext10 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext11 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext12 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext13 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext14 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext15 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext16 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext17 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext17.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext18 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext19 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext20 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext21 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext22 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext23 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext24 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext3_ForReadOnly valDataContext25 = ((Workflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext3(locations, activityContext, true);
                }
                Workflow_TypedDataContext3 refDataContext26 = ((Workflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext26.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext3(locations, activityContext, true);
                }
                Workflow_TypedDataContext3 refDataContext27 = ((Workflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext3_ForReadOnly valDataContext28 = ((Workflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow_TypedDataContext3(locations, activityContext, true);
                }
                Workflow_TypedDataContext3 refDataContext29 = ((Workflow_TypedDataContext3)(cachedCompiledDataContext[3]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext3_ForReadOnly valDataContext30 = ((Workflow_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[2]));
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext31 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext32 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow_TypedDataContext4(locations, activityContext, true);
                }
                Workflow_TypedDataContext4 refDataContext33 = ((Workflow_TypedDataContext4)(cachedCompiledDataContext[5]));
                return refDataContext33.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext34 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext35 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext36 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext4_ForReadOnly valDataContext37 = ((Workflow_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[4]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext38 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext39 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext40 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext41 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext42 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext42.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext43 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext44 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext45 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext45.GetLocation<string>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext46 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext47 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext48 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext48.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext49 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext50 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext51 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext52 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow_TypedDataContext2(locations, activityContext, true);
                }
                Workflow_TypedDataContext2 refDataContext53 = ((Workflow_TypedDataContext2)(cachedCompiledDataContext[0]));
                return refDataContext53.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 54)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext54 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 6);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow_TypedDataContext2_ForReadOnly valDataContext55 = ((Workflow_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext55.ValueType___Expr55Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow_TypedDataContext2 refDataContext0 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext0.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext0.ValueType___Expr0Get, refDataContext0.ValueType___Expr0Set);
            }
            if ((expressionId == 1)) {
                Workflow_TypedDataContext2 refDataContext1 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext1.GetLocation<string>(refDataContext1.ValueType___Expr1Get, refDataContext1.ValueType___Expr1Set);
            }
            if ((expressionId == 2)) {
                Workflow_TypedDataContext2 refDataContext2 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext2.GetLocation<int>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Workflow_TypedDataContext2 refDataContext3 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext3.GetLocation<string>(refDataContext3.ValueType___Expr3Get, refDataContext3.ValueType___Expr3Set);
            }
            if ((expressionId == 4)) {
                Workflow_TypedDataContext2 refDataContext4 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext4.GetLocation<System.DateTime>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Workflow_TypedDataContext2 refDataContext5 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext5.GetLocation<int>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Workflow_TypedDataContext2 refDataContext6 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext6.GetLocation<string>(refDataContext6.ValueType___Expr6Get, refDataContext6.ValueType___Expr6Set);
            }
            if ((expressionId == 7)) {
                Workflow_TypedDataContext2 refDataContext7 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Workflow_TypedDataContext2 refDataContext8 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext8.GetLocation<System.DateTime>(refDataContext8.ValueType___Expr8Get, refDataContext8.ValueType___Expr8Set);
            }
            if ((expressionId == 9)) {
                Workflow_TypedDataContext2 refDataContext9 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Workflow_TypedDataContext2 refDataContext10 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext10.GetLocation<string>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Workflow_TypedDataContext2 refDataContext11 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext11.GetLocation<int>(refDataContext11.ValueType___Expr11Get, refDataContext11.ValueType___Expr11Set);
            }
            if ((expressionId == 12)) {
                Workflow_TypedDataContext2 refDataContext12 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext12.GetLocation<string>(refDataContext12.ValueType___Expr12Get, refDataContext12.ValueType___Expr12Set);
            }
            if ((expressionId == 13)) {
                Workflow_TypedDataContext2 refDataContext13 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext13.GetLocation<string>(refDataContext13.ValueType___Expr13Get, refDataContext13.ValueType___Expr13Set);
            }
            if ((expressionId == 14)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext14 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext14.ValueType___Expr14Get();
            }
            if ((expressionId == 15)) {
                Workflow_TypedDataContext2 refDataContext15 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext15.GetLocation<int>(refDataContext15.ValueType___Expr15Get, refDataContext15.ValueType___Expr15Set);
            }
            if ((expressionId == 16)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext16 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext16.ValueType___Expr16Get();
            }
            if ((expressionId == 17)) {
                Workflow_TypedDataContext2 refDataContext17 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext17.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext17.ValueType___Expr17Get, refDataContext17.ValueType___Expr17Set);
            }
            if ((expressionId == 18)) {
                Workflow_TypedDataContext2 refDataContext18 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext19 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext19.ValueType___Expr19Get();
            }
            if ((expressionId == 20)) {
                Workflow_TypedDataContext2 refDataContext20 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext20.GetLocation<string>(refDataContext20.ValueType___Expr20Get, refDataContext20.ValueType___Expr20Set);
            }
            if ((expressionId == 21)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext21 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext22 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext23 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext24 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext24.ValueType___Expr24Get();
            }
            if ((expressionId == 25)) {
                Workflow_TypedDataContext3_ForReadOnly valDataContext25 = new Workflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext25.ValueType___Expr25Get();
            }
            if ((expressionId == 26)) {
                Workflow_TypedDataContext3 refDataContext26 = new Workflow_TypedDataContext3(locations, true);
                return refDataContext26.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext26.ValueType___Expr26Get, refDataContext26.ValueType___Expr26Set);
            }
            if ((expressionId == 27)) {
                Workflow_TypedDataContext3 refDataContext27 = new Workflow_TypedDataContext3(locations, true);
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Workflow_TypedDataContext3_ForReadOnly valDataContext28 = new Workflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Workflow_TypedDataContext3 refDataContext29 = new Workflow_TypedDataContext3(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Workflow_TypedDataContext3_ForReadOnly valDataContext30 = new Workflow_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext30.ValueType___Expr30Get();
            }
            if ((expressionId == 31)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext31 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext31.ValueType___Expr31Get();
            }
            if ((expressionId == 32)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext32 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext32.ValueType___Expr32Get();
            }
            if ((expressionId == 33)) {
                Workflow_TypedDataContext4 refDataContext33 = new Workflow_TypedDataContext4(locations, true);
                return refDataContext33.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext33.ValueType___Expr33Get, refDataContext33.ValueType___Expr33Set);
            }
            if ((expressionId == 34)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext34 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext34.ValueType___Expr34Get();
            }
            if ((expressionId == 35)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext35 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext35.ValueType___Expr35Get();
            }
            if ((expressionId == 36)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext36 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Workflow_TypedDataContext4_ForReadOnly valDataContext37 = new Workflow_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext38 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext38.ValueType___Expr38Get();
            }
            if ((expressionId == 39)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext39 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext40 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext41 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext41.ValueType___Expr41Get();
            }
            if ((expressionId == 42)) {
                Workflow_TypedDataContext2 refDataContext42 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext42.GetLocation<Microsoft.Activities.DynamicValue>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Workflow_TypedDataContext2 refDataContext43 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext43.GetLocation<string>(refDataContext43.ValueType___Expr43Get, refDataContext43.ValueType___Expr43Set);
            }
            if ((expressionId == 44)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext44 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                Workflow_TypedDataContext2 refDataContext45 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext45.GetLocation<string>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext46 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext47 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext47.ValueType___Expr47Get();
            }
            if ((expressionId == 48)) {
                Workflow_TypedDataContext2 refDataContext48 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext48.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext48.ValueType___Expr48Get, refDataContext48.ValueType___Expr48Set);
            }
            if ((expressionId == 49)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext49 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext50 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext50.ValueType___Expr50Get();
            }
            if ((expressionId == 51)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext51 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext51.ValueType___Expr51Get();
            }
            if ((expressionId == 52)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext52 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext52.ValueType___Expr52Get();
            }
            if ((expressionId == 53)) {
                Workflow_TypedDataContext2 refDataContext53 = new Workflow_TypedDataContext2(locations, true);
                return refDataContext53.GetLocation<System.Collections.ObjectModel.Collection<string>>(refDataContext53.ValueType___Expr53Get, refDataContext53.ValueType___Expr53Set);
            }
            if ((expressionId == 54)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext54 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext54.ValueType___Expr54Get();
            }
            if ((expressionId == 55)) {
                Workflow_TypedDataContext2_ForReadOnly valDataContext55 = new Workflow_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext55.ValueType___Expr55Get();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == true) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestID") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver2Id") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "approverUrl") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "startDate") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1Id") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver3StatusText") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "cancelStatus") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "endDate") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver2StatusText") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "timeOffType") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestedBy") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestStatus") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1StatusText") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_0") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver3Id") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedBy") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dv_4") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestedByEmail") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_4") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "RequestedByName") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Request Status:\" + RequestStatus + \"|Approver 1:\" + Approver1Id") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedByName") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "cancelStatus == \"Cancel\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestStatus == \"Pending Approval\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1Id") 
                        && (Workflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dv_1") 
                        && (Workflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1Email") 
                        && (Workflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_1") 
                        && (Workflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1Text") 
                        && (Workflow_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1StatusText == \"Pending Approval\"") 
                        && (Workflow_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"in approver 1 email\" + Approver1Email") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1Email") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedByName + \"  Cancelled the pending Time Off request. \\n\\nTime Off request" +
                            " details -\\n Time off Type: \" + timeOffType + \"\\n Start Date: \" + startDate.ToSt" +
                            "ring() + \"\\n End Date: \" + endDate.ToString()") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Cancellation of Time Off Request by \" + RequestedByName") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Email sent to : \" + emaillist[0]") 
                        && (Workflow_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestStatus == \"Approved\"") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Approved Request for Cancellation Email \" + RequestedByEmail") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1Id > 0") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1Id") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "dv_1") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1Email") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "dv_1") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "Approver1Text") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Approver1Email") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedByEmail") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Requester Email: \" +  RequestedByEmail +\"\\n\\n Approver1email: \"+ Approver1Email") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == @"RequestedByName + "" is requesting to cancel his Approved Time Off Request.\n Time off request details:\n Time off Type: "" + timeOffType + ""\n Start Date: "" + startDate.ToString() + ""\n End Date: "" + endDate.ToString() + ""\n\n To Proceed with Cancellation of the request, copy and paste the url below in your browser:\n\n"" + approverUrl.Replace(""ApprovalForm.aspx"", ""PendingRequestsApprover.aspx"")") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 51;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedByEmail") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 52;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext2.Validate(locations, true, 0) == true)))) {
                expressionId = 53;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "emaillist") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 54;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "RequestedByName +\" is requesting to cancel his Approved Time Off Request.\\n Time " +
                            "off request details:\\n Time off Type: \" + timeOffType + \"\\n Start Date: \" + star" +
                            "tDate.ToString() + \"\\n End Date: \" + endDate.ToString()") 
                        && (Workflow_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 55;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Workflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Workflow_TypedDataContext3(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Workflow_TypedDataContext3(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Workflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Workflow_TypedDataContext3(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Workflow_TypedDataContext3_ForReadOnly(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Workflow_TypedDataContext4(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Workflow_TypedDataContext4_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr50GetTree();
            }
            if ((expressionId == 51)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr51GetTree();
            }
            if ((expressionId == 52)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr52GetTree();
            }
            if ((expressionId == 53)) {
                return new Workflow_TypedDataContext2(locationReferences).@__Expr53GetTree();
            }
            if ((expressionId == 54)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr54GetTree();
            }
            if ((expressionId == 55)) {
                return new Workflow_TypedDataContext2_ForReadOnly(locationReferences).@__Expr55GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1 : Workflow_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext1_ForReadOnly : Workflow_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2 : Workflow_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int RequestedBy;
            
            protected int Approver1Id;
            
            protected int Approver2Id;
            
            protected int Approver3Id;
            
            protected System.DateTime startDate;
            
            protected System.DateTime endDate;
            
            protected int keyIdDeptCalendar;
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string RequestStatus {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            protected string Approver1Text {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string Approver2Text {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string Approver3Text {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            protected string RequestedName {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((5 + locationsOffset), value);
                }
            }
            
            protected string Approver1StatusText {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((6 + locationsOffset), value);
                }
            }
            
            protected string Approver2StatusText {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((7 + locationsOffset), value);
                }
            }
            
            protected string Approver3StatusText {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((8 + locationsOffset), value);
                }
            }
            
            protected string Approver1Email {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((9 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_1 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((12 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((12 + locationsOffset), value);
                }
            }
            
            protected string Approver2Email {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((15 + locationsOffset), value);
                }
            }
            
            protected string Approver3Email {
                get {
                    return ((string)(this.GetVariableValue((16 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((16 + locationsOffset), value);
                }
            }
            
            protected string RequestedByName {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((17 + locationsOffset), value);
                }
            }
            
            protected string RequestedByEmail {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((18 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_2 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((19 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((19 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_3 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((20 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((20 + locationsOffset), value);
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_4 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((21 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((21 + locationsOffset), value);
                }
            }
            
            protected string approverUrl {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((24 + locationsOffset), value);
                }
            }
            
            protected string timeOffType {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((25 + locationsOffset), value);
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> emaillist {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((26 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((26 + locationsOffset), value);
                }
            }
            
            protected string cancelStatus {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((28 + locationsOffset), value);
                }
            }
            
            protected string RequestID {
                get {
                    return ((string)(this.GetVariableValue((29 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((29 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 92 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr0Get() {
                
                #line 92 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr0Set(Microsoft.Activities.DynamicValue value) {
                
                #line 92 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          dv_0 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr0Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr0Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 144 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          RequestID;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 144 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestID;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr1Set(string value) {
                
                #line 144 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          RequestID = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr1Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr1Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 111 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          Approver2Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr2Get() {
                
                #line 111 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver2Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(int value) {
                
                #line 111 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver2Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 135 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          approverUrl;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 135 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          approverUrl;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr3Set(string value) {
                
                #line 135 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          approverUrl = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr3Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr3Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 129 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
          startDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr4Get() {
                
                #line 129 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          startDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(System.DateTime value) {
                
                #line 129 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          startDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 108 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          Approver1Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr5Get() {
                
                #line 108 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver1Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(int value) {
                
                #line 108 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver1Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 123 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Approver3StatusText;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 123 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver3StatusText;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr6Set(string value) {
                
                #line 123 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver3StatusText = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr6Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr6Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 141 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          cancelStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 141 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          cancelStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 141 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          cancelStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 132 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.DateTime>> expression = () => 
          endDate;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.DateTime @__Expr8Get() {
                
                #line 132 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          endDate;
                
                #line default
                #line hidden
            }
            
            public System.DateTime ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr8Set(System.DateTime value) {
                
                #line 132 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          endDate = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr8Set(System.DateTime value) {
                this.GetValueTypeValues();
                this.@__Expr8Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 120 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Approver2StatusText;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 120 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver2StatusText;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 120 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver2StatusText = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 138 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          timeOffType;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr10Get() {
                
                #line 138 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          timeOffType;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(string value) {
                
                #line 138 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          timeOffType = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 126 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          RequestedBy;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr11Get() {
                
                #line 126 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestedBy;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr11Set(int value) {
                
                #line 126 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          RequestedBy = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr11Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr11Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 105 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          RequestStatus;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 105 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestStatus;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr12Set(string value) {
                
                #line 105 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          RequestStatus = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr12Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr12Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 117 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          Approver1StatusText;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr13Get() {
                
                #line 117 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver1StatusText;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr13Set(string value) {
                
                #line 117 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver1StatusText = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr13Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr13Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 114 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          Approver3Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr15Get() {
                
                #line 114 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          Approver3Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr15Set(int value) {
                
                #line 114 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          Approver3Id = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr15Set(int value) {
                this.GetValueTypeValues();
                this.@__Expr15Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 156 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_4;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr17Get() {
                
                #line 156 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          dv_4;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr17Set(Microsoft.Activities.DynamicValue value) {
                
                #line 156 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          dv_4 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr17Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr17Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 168 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          RequestedByEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 168 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestedByEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(string value) {
                
                #line 168 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          RequestedByEmail = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 171 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          RequestedByName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 171 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestedByName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr20Set(string value) {
                
                #line 171 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
          RequestedByName = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr20Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr20Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 371 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                  dv_1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr42Get() {
                
                #line 371 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  dv_1;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(Microsoft.Activities.DynamicValue value) {
                
                #line 371 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                                  dv_1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 383 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 383 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr43Set(string value) {
                
                #line 383 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                                  Approver1Email = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr43Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr43Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 386 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Approver1Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 386 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  Approver1Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(string value) {
                
                #line 386 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                                  Approver1Text = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 393 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                  emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr48Get() {
                
                #line 393 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr48Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 393 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                                  emaillist = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr48Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr48Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr53GetTree() {
                
                #line 433 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                  emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr53Get() {
                
                #line 433 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr53Get() {
                this.GetValueTypeValues();
                return this.@__Expr53Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr53Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 433 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                                  emaillist = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr53Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr53Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.RequestedBy = ((int)(this.GetVariableValue((10 + locationsOffset))));
                this.Approver1Id = ((int)(this.GetVariableValue((11 + locationsOffset))));
                this.Approver2Id = ((int)(this.GetVariableValue((13 + locationsOffset))));
                this.Approver3Id = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.startDate = ((System.DateTime)(this.GetVariableValue((22 + locationsOffset))));
                this.endDate = ((System.DateTime)(this.GetVariableValue((23 + locationsOffset))));
                this.keyIdDeptCalendar = ((int)(this.GetVariableValue((27 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((10 + locationsOffset), this.RequestedBy);
                this.SetVariableValue((11 + locationsOffset), this.Approver1Id);
                this.SetVariableValue((13 + locationsOffset), this.Approver2Id);
                this.SetVariableValue((14 + locationsOffset), this.Approver3Id);
                this.SetVariableValue((22 + locationsOffset), this.startDate);
                this.SetVariableValue((23 + locationsOffset), this.endDate);
                this.SetVariableValue((27 + locationsOffset), this.keyIdDeptCalendar);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 30))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 30);
                }
                expectedLocationsCount = 30;
                if (((locationReferences[(offset + 0)].Name != "dv_0") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "RequestStatus") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Approver1Text") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Approver2Text") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Approver3Text") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "RequestedName") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Approver1StatusText") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Approver2StatusText") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Approver3StatusText") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Approver1Email") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "dv_1") 
                            || (locationReferences[(offset + 12)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Approver2Email") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Approver3Email") 
                            || (locationReferences[(offset + 16)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "RequestedByName") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "RequestedByEmail") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "dv_2") 
                            || (locationReferences[(offset + 19)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "dv_3") 
                            || (locationReferences[(offset + 20)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "dv_4") 
                            || (locationReferences[(offset + 21)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "approverUrl") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "timeOffType") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "emaillist") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "cancelStatus") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 29)].Name != "RequestID") 
                            || (locationReferences[(offset + 29)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "RequestedBy") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Approver1Id") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Approver2Id") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Approver3Id") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "startDate") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "endDate") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "keyIdDeptCalendar") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext2_ForReadOnly : Workflow_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected int RequestedBy;
            
            protected int Approver1Id;
            
            protected int Approver2Id;
            
            protected int Approver3Id;
            
            protected System.DateTime startDate;
            
            protected System.DateTime endDate;
            
            protected int keyIdDeptCalendar;
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_0 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string RequestStatus {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            protected string Approver1Text {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string Approver2Text {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string Approver3Text {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            protected string RequestedName {
                get {
                    return ((string)(this.GetVariableValue((5 + locationsOffset))));
                }
            }
            
            protected string Approver1StatusText {
                get {
                    return ((string)(this.GetVariableValue((6 + locationsOffset))));
                }
            }
            
            protected string Approver2StatusText {
                get {
                    return ((string)(this.GetVariableValue((7 + locationsOffset))));
                }
            }
            
            protected string Approver3StatusText {
                get {
                    return ((string)(this.GetVariableValue((8 + locationsOffset))));
                }
            }
            
            protected string Approver1Email {
                get {
                    return ((string)(this.GetVariableValue((9 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_1 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((12 + locationsOffset))));
                }
            }
            
            protected string Approver2Email {
                get {
                    return ((string)(this.GetVariableValue((15 + locationsOffset))));
                }
            }
            
            protected string Approver3Email {
                get {
                    return ((string)(this.GetVariableValue((16 + locationsOffset))));
                }
            }
            
            protected string RequestedByName {
                get {
                    return ((string)(this.GetVariableValue((17 + locationsOffset))));
                }
            }
            
            protected string RequestedByEmail {
                get {
                    return ((string)(this.GetVariableValue((18 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_2 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((19 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_3 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((20 + locationsOffset))));
                }
            }
            
            protected Microsoft.Activities.DynamicValue dv_4 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((21 + locationsOffset))));
                }
            }
            
            protected string approverUrl {
                get {
                    return ((string)(this.GetVariableValue((24 + locationsOffset))));
                }
            }
            
            protected string timeOffType {
                get {
                    return ((string)(this.GetVariableValue((25 + locationsOffset))));
                }
            }
            
            protected System.Collections.ObjectModel.Collection<string> emaillist {
                get {
                    return ((System.Collections.ObjectModel.Collection<string>)(this.GetVariableValue((26 + locationsOffset))));
                }
            }
            
            protected string cancelStatus {
                get {
                    return ((string)(this.GetVariableValue((28 + locationsOffset))));
                }
            }
            
            protected string RequestID {
                get {
                    return ((string)(this.GetVariableValue((29 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 100 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr14Get() {
                
                #line 100 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          dv_0;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 151 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
          RequestedBy;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr16Get() {
                
                #line 151 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          RequestedBy;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 163 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
          dv_4;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr19Get() {
                
                #line 163 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          dv_4;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 178 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          "Request Status:" + RequestStatus + "|Approver 1:" + Approver1Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 178 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          "Request Status:" + RequestStatus + "|Approver 1:" + Approver1Id;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 202 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                RequestedByName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr22Get() {
                
                #line 202 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                RequestedByName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 212 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
          cancelStatus == "Cancel";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr23Get() {
                
                #line 212 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
          cancelStatus == "Cancel";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 221 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                RequestStatus == "Pending Approval";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr24Get() {
                
                #line 221 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                RequestStatus == "Pending Approval";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 342 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      RequestStatus == "Approved";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr38Get() {
                
                #line 342 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      RequestStatus == "Approved";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 350 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "Approved Request for Cancellation Email " + RequestedByEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 350 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            "Approved Request for Cancellation Email " + RequestedByEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 357 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                            Approver1Id > 0;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr40Get() {
                
                #line 357 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            Approver1Id > 0;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 366 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                                  Approver1Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr41Get() {
                
                #line 366 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  Approver1Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 378 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                                  dv_1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr44Get() {
                
                #line 378 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  dv_1;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 398 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr46Get() {
                
                #line 398 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 401 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  RequestedByEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 401 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  RequestedByEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 408 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  "Requester Email: " +  RequestedByEmail +"\n\n Approver1email: "+ Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr49Get() {
                
                #line 408 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  "Requester Email: " +  RequestedByEmail +"\n\n Approver1email: "+ Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 420 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                  emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr50Get() {
                
                #line 420 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr51GetTree() {
                
                #line 415 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  RequestedByName + " is requesting to cancel his Approved Time Off Request.\n Time off request details:\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString() + "\n\n To Proceed with Cancellation of the request, copy and paste the url below in your browser:\n\n" + approverUrl.Replace("ApprovalForm.aspx", "PendingRequestsApprover.aspx");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr51Get() {
                
                #line 415 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  RequestedByName + " is requesting to cancel his Approved Time Off Request.\n Time off request details:\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString() + "\n\n To Proceed with Cancellation of the request, copy and paste the url below in your browser:\n\n" + approverUrl.Replace("ApprovalForm.aspx", "PendingRequestsApprover.aspx");
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr51Get() {
                this.GetValueTypeValues();
                return this.@__Expr51Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr52GetTree() {
                
                #line 438 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  RequestedByEmail;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr52Get() {
                
                #line 438 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  RequestedByEmail;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr52Get() {
                this.GetValueTypeValues();
                return this.@__Expr52Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr54GetTree() {
                
                #line 450 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                                  emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr54Get() {
                
                #line 450 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr54Get() {
                this.GetValueTypeValues();
                return this.@__Expr54Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr55GetTree() {
                
                #line 445 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                                  RequestedByName +" is requesting to cancel his Approved Time Off Request.\n Time off request details:\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr55Get() {
                
                #line 445 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                                  RequestedByName +" is requesting to cancel his Approved Time Off Request.\n Time off request details:\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr55Get() {
                this.GetValueTypeValues();
                return this.@__Expr55Get();
            }
            
            protected override void GetValueTypeValues() {
                this.RequestedBy = ((int)(this.GetVariableValue((10 + locationsOffset))));
                this.Approver1Id = ((int)(this.GetVariableValue((11 + locationsOffset))));
                this.Approver2Id = ((int)(this.GetVariableValue((13 + locationsOffset))));
                this.Approver3Id = ((int)(this.GetVariableValue((14 + locationsOffset))));
                this.startDate = ((System.DateTime)(this.GetVariableValue((22 + locationsOffset))));
                this.endDate = ((System.DateTime)(this.GetVariableValue((23 + locationsOffset))));
                this.keyIdDeptCalendar = ((int)(this.GetVariableValue((27 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 30))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 30);
                }
                expectedLocationsCount = 30;
                if (((locationReferences[(offset + 0)].Name != "dv_0") 
                            || (locationReferences[(offset + 0)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "RequestStatus") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 2)].Name != "Approver1Text") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "Approver2Text") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "Approver3Text") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 5)].Name != "RequestedName") 
                            || (locationReferences[(offset + 5)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 6)].Name != "Approver1StatusText") 
                            || (locationReferences[(offset + 6)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 7)].Name != "Approver2StatusText") 
                            || (locationReferences[(offset + 7)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 8)].Name != "Approver3StatusText") 
                            || (locationReferences[(offset + 8)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 9)].Name != "Approver1Email") 
                            || (locationReferences[(offset + 9)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 12)].Name != "dv_1") 
                            || (locationReferences[(offset + 12)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 15)].Name != "Approver2Email") 
                            || (locationReferences[(offset + 15)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 16)].Name != "Approver3Email") 
                            || (locationReferences[(offset + 16)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 17)].Name != "RequestedByName") 
                            || (locationReferences[(offset + 17)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 18)].Name != "RequestedByEmail") 
                            || (locationReferences[(offset + 18)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 19)].Name != "dv_2") 
                            || (locationReferences[(offset + 19)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 20)].Name != "dv_3") 
                            || (locationReferences[(offset + 20)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 21)].Name != "dv_4") 
                            || (locationReferences[(offset + 21)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                if (((locationReferences[(offset + 24)].Name != "approverUrl") 
                            || (locationReferences[(offset + 24)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 25)].Name != "timeOffType") 
                            || (locationReferences[(offset + 25)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 26)].Name != "emaillist") 
                            || (locationReferences[(offset + 26)].Type != typeof(System.Collections.ObjectModel.Collection<string>)))) {
                    return false;
                }
                if (((locationReferences[(offset + 28)].Name != "cancelStatus") 
                            || (locationReferences[(offset + 28)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 29)].Name != "RequestID") 
                            || (locationReferences[(offset + 29)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 10)].Name != "RequestedBy") 
                            || (locationReferences[(offset + 10)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 11)].Name != "Approver1Id") 
                            || (locationReferences[(offset + 11)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 13)].Name != "Approver2Id") 
                            || (locationReferences[(offset + 13)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 14)].Name != "Approver3Id") 
                            || (locationReferences[(offset + 14)].Type != typeof(int)))) {
                    return false;
                }
                if (((locationReferences[(offset + 22)].Name != "startDate") 
                            || (locationReferences[(offset + 22)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 23)].Name != "endDate") 
                            || (locationReferences[(offset + 23)].Type != typeof(System.DateTime)))) {
                    return false;
                }
                if (((locationReferences[(offset + 27)].Name != "keyIdDeptCalendar") 
                            || (locationReferences[(offset + 27)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext3 : Workflow_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected new int RequestID;
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 238 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                      dv_1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr26Get() {
                
                #line 238 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      dv_1;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr26Set(Microsoft.Activities.DynamicValue value) {
                
                #line 238 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                      dv_1 = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr26Set(Microsoft.Activities.DynamicValue value) {
                this.GetValueTypeValues();
                this.@__Expr26Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 250 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 250 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(string value) {
                
                #line 250 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                      Approver1Email = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 253 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                      Approver1Text;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 253 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      Approver1Text;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 253 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                      Approver1Text = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.RequestID = ((int)(this.GetVariableValue((30 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((30 + locationsOffset), this.RequestID);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 31))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 31);
                }
                expectedLocationsCount = 31;
                if (((locationReferences[(offset + 30)].Name != "RequestID") 
                            || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext3_ForReadOnly : Workflow_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected new int RequestID;
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 233 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<int>> expression = () => 
                      Approver1Id;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public int @__Expr25Get() {
                
                #line 233 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      Approver1Id;
                
                #line default
                #line hidden
            }
            
            public int ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 245 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<Microsoft.Activities.DynamicValue>> expression = () => 
                      dv_1;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public Microsoft.Activities.DynamicValue @__Expr28Get() {
                
                #line 245 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      dv_1;
                
                #line default
                #line hidden
            }
            
            public Microsoft.Activities.DynamicValue ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 260 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
                      Approver1StatusText == "Pending Approval";
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr30Get() {
                
                #line 260 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                      Approver1StatusText == "Pending Approval";
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            protected override void GetValueTypeValues() {
                this.RequestID = ((int)(this.GetVariableValue((30 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 31))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 31);
                }
                expectedLocationsCount = 31;
                if (((locationReferences[(offset + 30)].Name != "RequestID") 
                            || (locationReferences[(offset + 30)].Type != typeof(int)))) {
                    return false;
                }
                return Workflow_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext4 : Workflow_TypedDataContext3 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_5 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((31 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((31 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 278 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                            emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr33Get() {
                
                #line 278 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr33Set(System.Collections.ObjectModel.Collection<string> value) {
                
                #line 278 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                
                            emaillist = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr33Set(System.Collections.ObjectModel.Collection<string> value) {
                this.GetValueTypeValues();
                this.@__Expr33Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 31)].Name != "dv_5") 
                            || (locationReferences[(offset + 31)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                return Workflow_TypedDataContext3.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow_TypedDataContext4_ForReadOnly : Workflow_TypedDataContext3_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected Microsoft.Activities.DynamicValue dv_5 {
                get {
                    return ((Microsoft.Activities.DynamicValue)(this.GetVariableValue((31 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 271 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "in approver 1 email" + Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 271 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            "in approver 1 email" + Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 283 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            Approver1Email;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 283 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            Approver1Email;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 301 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<System.Collections.ObjectModel.Collection<string>>> expression = () => 
                            emaillist;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public System.Collections.ObjectModel.Collection<string> @__Expr34Get() {
                
                #line 301 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            emaillist;
                
                #line default
                #line hidden
            }
            
            public System.Collections.ObjectModel.Collection<string> ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 291 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            RequestedByName + "  Cancelled the pending Time Off request. \n\nTime Off request details -\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 291 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            RequestedByName + "  Cancelled the pending Time Off request. \n\nTime Off request details -\n Time off Type: " + timeOffType + "\n Start Date: " + startDate.ToString() + "\n End Date: " + endDate.ToString();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 296 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "Cancellation of Time Off Request by " + RequestedByName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 296 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            "Cancellation of Time Off Request by " + RequestedByName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 308 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                            "Email sent to : " + emaillist[0];
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 308 "E:\SHAREPOINTAPPS\FERRIS TIMEOFF\CLOUDBEARING.TIMEOFFREQUEST\CANCELTIMEOFFWORKFLOW\WORKFLOW.XAML"
                return 
                            "Email sent to : " + emaillist[0];
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 32))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 32);
                }
                expectedLocationsCount = 32;
                if (((locationReferences[(offset + 31)].Name != "dv_5") 
                            || (locationReferences[(offset + 31)].Type != typeof(Microsoft.Activities.DynamicValue)))) {
                    return false;
                }
                return Workflow_TypedDataContext3_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
