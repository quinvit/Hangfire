﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\RecurringJobsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Pages\RecurringJobsPage.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\RecurringJobsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\RecurringJobsPage.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\RecurringJobsPage.cshtml"
    using HangFire.Common;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Pages\RecurringJobsPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Pages\RecurringJobsPage.cshtml"
    using HangFire.Web;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Pages\RecurringJobsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    #line 10 "..\..\Pages\RecurringJobsPage.cshtml"
    using Storage.Monitoring;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class RecurringJobsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");












            
            #line 12 "..\..\Pages\RecurringJobsPage.cshtml"
  
    Layout = new LayoutPage { Title = "Recurring jobs" };


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 16 "..\..\Pages\RecurringJobsPage.cshtml"
 if (RecurringJobs.Count == 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"alert alert-info\">\r\n        No recurring jobs found.\r\n    </div>\r" +
"\n");


            
            #line 21 "..\..\Pages\RecurringJobsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"js-jobs-list\">\r\n        <div class=\"btn-toolbar btn-toolbar-top\">" +
"\r\n            <button class=\"js-jobs-list-command btn btn-sm btn-primary\"\r\n     " +
"               data-url=\"");


            
            #line 27 "..\..\Pages\RecurringJobsPage.cshtml"
                         Write(Request.LinkTo("/recurring/trigger"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                    data-loading-text=""Triggering..."">
                <span class=""glyphicon glyphicon-play-circle""></span>
                Trigger now
            </button>

            <button class=""js-jobs-list-command btn btn-sm btn-default""
                    data-url=""");


            
            #line 34 "..\..\Pages\RecurringJobsPage.cshtml"
                         Write(Request.LinkTo("/recurring/remove"));

            
            #line default
            #line hidden
WriteLiteral(@"""
                    data-loading-text=""Removing...""
                    data-confirm=""Do you really want to REMOVE ALL selected jobs?"">
                <span class=""glyphicon glyphicon-remove""></span>
                Remove
            </button>
        </div>

        <table class=""table"">
            <thead>
                <tr>
                    <th class=""min-width"">
                        <input type=""checkbox"" class=""js-jobs-list-select-all"" />
                    </th>
                    <th class=""min-width"">Id</th>
                    <th class=""min-width"">Cron</th>
                    <th>Job</th>
                    <th class=""align-right min-width"">Next execution</th>
                    <th class=""align-right min-width"">Last execution</th>
                </tr>
            </thead>
            <tbody>
");


            
            #line 56 "..\..\Pages\RecurringJobsPage.cshtml"
                 foreach (var job in RecurringJobs)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr class=\"js-jobs-list-row hover\">\r\n                        " +
"<td>\r\n                            <input type=\"checkbox\" class=\"js-jobs-list-che" +
"ckbox\" name=\"jobs[]\" value=\"");


            
            #line 60 "..\..\Pages\RecurringJobsPage.cshtml"
                                                                                                 Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n                        </td>\r\n                        <td>");


            
            #line 62 "..\..\Pages\RecurringJobsPage.cshtml"
                       Write(job.Id);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td class=\"min-width\">");


            
            #line 63 "..\..\Pages\RecurringJobsPage.cshtml"
                                          Write(CronExpressionDescriptor.ExpressionDescriptor.GetDescription(job.Cron));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td>\r\n");


            
            #line 65 "..\..\Pages\RecurringJobsPage.cshtml"
                             if (job.Job != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral(" ");


            
            #line 67 "..\..\Pages\RecurringJobsPage.cshtml"
                              Write(HtmlHelper.DisplayMethod(job.Job));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 68 "..\..\Pages\RecurringJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>");


            
            #line 71 "..\..\Pages\RecurringJobsPage.cshtml"
                               Write(job.LoadException.InnerException.Message);

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n");


            
            #line 72 "..\..\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td class=\"align-right min" +
"-width\">\r\n");


            
            #line 75 "..\..\Pages\RecurringJobsPage.cshtml"
                             if (job.NextExecution != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span data-moment=\"");


            
            #line 77 "..\..\Pages\RecurringJobsPage.cshtml"
                                               Write(JobHelper.ToStringTimestamp(job.NextExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    ");


            
            #line 78 "..\..\Pages\RecurringJobsPage.cshtml"
                               Write(job.NextExecution.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                </span>\r\n");


            
            #line 80 "..\..\Pages\RecurringJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>N/A</em>\r\n");


            
            #line 84 "..\..\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td class=\"align-right min" +
"-width\">\r\n");


            
            #line 87 "..\..\Pages\RecurringJobsPage.cshtml"
                             if (job.LastExecution != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <a href=\"");


            
            #line 89 "..\..\Pages\RecurringJobsPage.cshtml"
                                    Write(Request.LinkTo("/job/" + job.LastJobId));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                    <span class=\"label label-default\" data-mo" +
"ment=\"");


            
            #line 90 "..\..\Pages\RecurringJobsPage.cshtml"
                                                                               Write(JobHelper.ToStringTimestamp(job.LastExecution.Value));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"");


            
            #line 90 "..\..\Pages\RecurringJobsPage.cshtml"
                                                                                                                                               Write(JobHistoryRenderer.ForegroundStateColors.ContainsKey(job.LastJobState) ? String.Format("background-color: {0};", JobHistoryRenderer.ForegroundStateColors[job.LastJobState]) : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                                        ");


            
            #line 91 "..\..\Pages\RecurringJobsPage.cshtml"
                                   Write(job.LastExecution.Value);

            
            #line default
            #line hidden
WriteLiteral("\r\n                                    </span>\r\n                                </" +
"a>\r\n");


            
            #line 94 "..\..\Pages\RecurringJobsPage.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <em>N/A</em>\r\n");


            
            #line 98 "..\..\Pages\RecurringJobsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                    </tr>\r\n");


            
            #line 101 "..\..\Pages\RecurringJobsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");


            
            #line 105 "..\..\Pages\RecurringJobsPage.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("    ");


        }
    }
}
#pragma warning restore 1591
