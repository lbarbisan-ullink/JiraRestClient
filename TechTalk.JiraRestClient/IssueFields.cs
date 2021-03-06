﻿using System;
using System.Collections.Generic;

namespace TechTalk.JiraRestClient
{
    public class IssueFields
    {
        public DateTime started;


        public IssueFields()
        {
            status = new Status();
            timetracking = new Timetracking();

            labels = new List<String>();
            comments = new List<Comment>();
            issuelinks = new List<IssueLink>();
            attachment = new List<Attachment>();
            watchers = new List<JiraUser>();
        }

        public String summary { get; set; }
        public String description { get; set; }
        public Timetracking timetracking { get; set; }
        public Status status { get; set; }

        public JiraUser reporter { get; set; }
        public JiraUser assignee { get; set; }
        public List<JiraUser> watchers { get; set; } 

        public List<String> labels { get; set; }
        public List<Comment> comments { get; set; }
        public List<IssueLink> issuelinks { get; set; }
        public List<Attachment> attachment { get; set; }
        public Issue<IssueFields> parent { get; set; }
        public IssueType issuetype { get; set; }
        public IssuePriority priority { get; set;}
        public string resolutiondate { get; set; }

        public DateTime? ResolutionDateTime
        {
            get
            {
                if (resolutiondate == null)
                    return null;
                return new DateTime(int.Parse(resolutiondate.Substring(0, 4)),
                                    int.Parse(resolutiondate.Substring(5, 2)),
                                    int.Parse(resolutiondate.Substring(8, 2)));
            }
        }
        //GLOBAL Rank
        public string customfield_21600 { get; set; }
        //EPIC LINK
        public string customfield_14700 { get; set; }
        //EPIC Name
        public string customfield_14701 { get; set; }
        //Story Point
        public double customfield_10790 { get; set; }
    }
}
