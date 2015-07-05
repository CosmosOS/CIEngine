using System;
using Newtonsoft.Json.Linq;

namespace Cosmos.CIEngine.GithubClient.Objects
{

    public class Event
    {
        public string id
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public Actor actor
        {
            get;
            set;
        }

        public Repo repo
        {
            get;
            set;
        }

        public JObject payload
        {
            get;
            set;
        }

        public bool _public
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public Org org
        {
            get;
            set;
        }
    }

    public class Actor
    {
        public int id
        {
            get;
            set;
        }

        public string login
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }
    }

    public class Repo
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }
    }

    public class Payload
    {
        public int push_id
        {
            get;
            set;
        }

        public int size
        {
            get;
            set;
        }

        public int distinct_size
        {
            get;
            set;
        }

        public string _ref
        {
            get;
            set;
        }

        public string head
        {
            get;
            set;
        }

        public string before
        {
            get;
            set;
        }

        public Commit[] commits
        {
            get;
            set;
        }

        public string action
        {
            get;
            set;
        }

        public int number
        {
            get;
            set;
        }

        public Pull_Request pull_request
        {
            get;
            set;
        }

        public Issue1 issue
        {
            get;
            set;
        }

        public Comment comment
        {
            get;
            set;
        }

        public string ref_type
        {
            get;
            set;
        }

        public string pusher_type
        {
            get;
            set;
        }
    }

    public class Pull_Request
    {
        public string url
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string diff_url
        {
            get;
            set;
        }

        public string patch_url
        {
            get;
            set;
        }

        public string issue_url
        {
            get;
            set;
        }

        public int number
        {
            get;
            set;
        }

        public string state
        {
            get;
            set;
        }

        public bool locked
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }

        public User user
        {
            get;
            set;
        }

        public string body
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public DateTime updated_at
        {
            get;
            set;
        }

        public DateTime? closed_at
        {
            get;
            set;
        }

        public DateTime? merged_at
        {
            get;
            set;
        }

        public string merge_commit_sha
        {
            get;
            set;
        }

        public object assignee
        {
            get;
            set;
        }

        public object milestone
        {
            get;
            set;
        }

        public string commits_url
        {
            get;
            set;
        }

        public string review_comments_url
        {
            get;
            set;
        }

        public string review_comment_url
        {
            get;
            set;
        }

        public string comments_url
        {
            get;
            set;
        }

        public string statuses_url
        {
            get;
            set;
        }

        public Head head
        {
            get;
            set;
        }

        public Base _base
        {
            get;
            set;
        }

        public _Links _links
        {
            get;
            set;
        }

        public bool merged
        {
            get;
            set;
        }

        public object mergeable
        {
            get;
            set;
        }

        public string mergeable_state
        {
            get;
            set;
        }

        public Merged_By merged_by
        {
            get;
            set;
        }

        public int comments
        {
            get;
            set;
        }

        public int review_comments
        {
            get;
            set;
        }

        public int commits
        {
            get;
            set;
        }

        public int additions
        {
            get;
            set;
        }

        public int deletions
        {
            get;
            set;
        }

        public int changed_files
        {
            get;
            set;
        }
    }

    public class User
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Head
    {
        public string label
        {
            get;
            set;
        }

        public string _ref
        {
            get;
            set;
        }

        public string sha
        {
            get;
            set;
        }

        public User1 user
        {
            get;
            set;
        }

        public Repo1 repo
        {
            get;
            set;
        }
    }

    public class User1
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Repo1
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string full_name
        {
            get;
            set;
        }

        public Owner owner
        {
            get;
            set;
        }

        public bool _private
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public bool fork
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string forks_url
        {
            get;
            set;
        }

        public string keys_url
        {
            get;
            set;
        }

        public string collaborators_url
        {
            get;
            set;
        }

        public string teams_url
        {
            get;
            set;
        }

        public string hooks_url
        {
            get;
            set;
        }

        public string issue_events_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string assignees_url
        {
            get;
            set;
        }

        public string branches_url
        {
            get;
            set;
        }

        public string tags_url
        {
            get;
            set;
        }

        public string blobs_url
        {
            get;
            set;
        }

        public string git_tags_url
        {
            get;
            set;
        }

        public string git_refs_url
        {
            get;
            set;
        }

        public string trees_url
        {
            get;
            set;
        }

        public string statuses_url
        {
            get;
            set;
        }

        public string languages_url
        {
            get;
            set;
        }

        public string stargazers_url
        {
            get;
            set;
        }

        public string contributors_url
        {
            get;
            set;
        }

        public string subscribers_url
        {
            get;
            set;
        }

        public string subscription_url
        {
            get;
            set;
        }

        public string commits_url
        {
            get;
            set;
        }

        public string git_commits_url
        {
            get;
            set;
        }

        public string comments_url
        {
            get;
            set;
        }

        public string issue_comment_url
        {
            get;
            set;
        }

        public string contents_url
        {
            get;
            set;
        }

        public string compare_url
        {
            get;
            set;
        }

        public string merges_url
        {
            get;
            set;
        }

        public string archive_url
        {
            get;
            set;
        }

        public string downloads_url
        {
            get;
            set;
        }

        public string issues_url
        {
            get;
            set;
        }

        public string pulls_url
        {
            get;
            set;
        }

        public string milestones_url
        {
            get;
            set;
        }

        public string notifications_url
        {
            get;
            set;
        }

        public string labels_url
        {
            get;
            set;
        }

        public string releases_url
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public DateTime updated_at
        {
            get;
            set;
        }

        public DateTime pushed_at
        {
            get;
            set;
        }

        public string git_url
        {
            get;
            set;
        }

        public string ssh_url
        {
            get;
            set;
        }

        public string clone_url
        {
            get;
            set;
        }

        public string svn_url
        {
            get;
            set;
        }

        public string homepage
        {
            get;
            set;
        }

        public int size
        {
            get;
            set;
        }

        public int stargazers_count
        {
            get;
            set;
        }

        public int watchers_count
        {
            get;
            set;
        }

        public string language
        {
            get;
            set;
        }

        public bool has_issues
        {
            get;
            set;
        }

        public bool has_downloads
        {
            get;
            set;
        }

        public bool has_wiki
        {
            get;
            set;
        }

        public bool has_pages
        {
            get;
            set;
        }

        public int forks_count
        {
            get;
            set;
        }

        public object mirror_url
        {
            get;
            set;
        }

        public int open_issues_count
        {
            get;
            set;
        }

        public int forks
        {
            get;
            set;
        }

        public int open_issues
        {
            get;
            set;
        }

        public int watchers
        {
            get;
            set;
        }

        public string default_branch
        {
            get;
            set;
        }
    }

    public class Owner
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Base
    {
        public string label
        {
            get;
            set;
        }

        public string _ref
        {
            get;
            set;
        }

        public string sha
        {
            get;
            set;
        }

        public User2 user
        {
            get;
            set;
        }

        public Repo2 repo
        {
            get;
            set;
        }
    }

    public class User2
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Repo2
    {
        public int id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string full_name
        {
            get;
            set;
        }

        public Owner1 owner
        {
            get;
            set;
        }

        public bool _private
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string description
        {
            get;
            set;
        }

        public bool fork
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string forks_url
        {
            get;
            set;
        }

        public string keys_url
        {
            get;
            set;
        }

        public string collaborators_url
        {
            get;
            set;
        }

        public string teams_url
        {
            get;
            set;
        }

        public string hooks_url
        {
            get;
            set;
        }

        public string issue_events_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string assignees_url
        {
            get;
            set;
        }

        public string branches_url
        {
            get;
            set;
        }

        public string tags_url
        {
            get;
            set;
        }

        public string blobs_url
        {
            get;
            set;
        }

        public string git_tags_url
        {
            get;
            set;
        }

        public string git_refs_url
        {
            get;
            set;
        }

        public string trees_url
        {
            get;
            set;
        }

        public string statuses_url
        {
            get;
            set;
        }

        public string languages_url
        {
            get;
            set;
        }

        public string stargazers_url
        {
            get;
            set;
        }

        public string contributors_url
        {
            get;
            set;
        }

        public string subscribers_url
        {
            get;
            set;
        }

        public string subscription_url
        {
            get;
            set;
        }

        public string commits_url
        {
            get;
            set;
        }

        public string git_commits_url
        {
            get;
            set;
        }

        public string comments_url
        {
            get;
            set;
        }

        public string issue_comment_url
        {
            get;
            set;
        }

        public string contents_url
        {
            get;
            set;
        }

        public string compare_url
        {
            get;
            set;
        }

        public string merges_url
        {
            get;
            set;
        }

        public string archive_url
        {
            get;
            set;
        }

        public string downloads_url
        {
            get;
            set;
        }

        public string issues_url
        {
            get;
            set;
        }

        public string pulls_url
        {
            get;
            set;
        }

        public string milestones_url
        {
            get;
            set;
        }

        public string notifications_url
        {
            get;
            set;
        }

        public string labels_url
        {
            get;
            set;
        }

        public string releases_url
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public DateTime updated_at
        {
            get;
            set;
        }

        public DateTime pushed_at
        {
            get;
            set;
        }

        public string git_url
        {
            get;
            set;
        }

        public string ssh_url
        {
            get;
            set;
        }

        public string clone_url
        {
            get;
            set;
        }

        public string svn_url
        {
            get;
            set;
        }

        public string homepage
        {
            get;
            set;
        }

        public int size
        {
            get;
            set;
        }

        public int stargazers_count
        {
            get;
            set;
        }

        public int watchers_count
        {
            get;
            set;
        }

        public string language
        {
            get;
            set;
        }

        public bool has_issues
        {
            get;
            set;
        }

        public bool has_downloads
        {
            get;
            set;
        }

        public bool has_wiki
        {
            get;
            set;
        }

        public bool has_pages
        {
            get;
            set;
        }

        public int forks_count
        {
            get;
            set;
        }

        public object mirror_url
        {
            get;
            set;
        }

        public int open_issues_count
        {
            get;
            set;
        }

        public int forks
        {
            get;
            set;
        }

        public int open_issues
        {
            get;
            set;
        }

        public int watchers
        {
            get;
            set;
        }

        public string default_branch
        {
            get;
            set;
        }
    }

    public class Owner1
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class _Links
    {
        public Self self
        {
            get;
            set;
        }

        public Html html
        {
            get;
            set;
        }

        public Issue issue
        {
            get;
            set;
        }

        public Comments comments
        {
            get;
            set;
        }

        public Review_Comments review_comments
        {
            get;
            set;
        }

        public Review_Comment review_comment
        {
            get;
            set;
        }

        public Commits commits
        {
            get;
            set;
        }

        public Statuses statuses
        {
            get;
            set;
        }
    }

    public class Self
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Html
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Issue
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Comments
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Review_Comments
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Review_Comment
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Commits
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Statuses
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Merged_By
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Issue1
    {
        public string url
        {
            get;
            set;
        }

        public string labels_url
        {
            get;
            set;
        }

        public string comments_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public int number
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }

        public User3 user
        {
            get;
            set;
        }

        public Label[] labels
        {
            get;
            set;
        }

        public string state
        {
            get;
            set;
        }

        public bool locked
        {
            get;
            set;
        }

        public Assignee assignee
        {
            get;
            set;
        }

        public object milestone
        {
            get;
            set;
        }

        public int comments
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public DateTime updated_at
        {
            get;
            set;
        }

        public DateTime? closed_at
        {
            get;
            set;
        }

        public string body
        {
            get;
            set;
        }

        public Pull_Request1 pull_request
        {
            get;
            set;
        }
    }

    public class User3
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Assignee
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class Pull_Request1
    {
        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string diff_url
        {
            get;
            set;
        }

        public string patch_url
        {
            get;
            set;
        }
    }

    public class Label
    {
        public string url
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }

        public string color
        {
            get;
            set;
        }
    }

    public class Comment
    {
        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string issue_url
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public User4 user
        {
            get;
            set;
        }

        public DateTime created_at
        {
            get;
            set;
        }

        public DateTime updated_at
        {
            get;
            set;
        }

        public string body
        {
            get;
            set;
        }

        public string diff_hunk
        {
            get;
            set;
        }

        public string path
        {
            get;
            set;
        }

        public int position
        {
            get;
            set;
        }

        public int original_position
        {
            get;
            set;
        }

        public string commit_id
        {
            get;
            set;
        }

        public string original_commit_id
        {
            get;
            set;
        }

        public string pull_request_url
        {
            get;
            set;
        }

        public _Links1 _links
        {
            get;
            set;
        }
    }

    public class User4
    {
        public string login
        {
            get;
            set;
        }

        public int id
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string html_url
        {
            get;
            set;
        }

        public string followers_url
        {
            get;
            set;
        }

        public string following_url
        {
            get;
            set;
        }

        public string gists_url
        {
            get;
            set;
        }

        public string starred_url
        {
            get;
            set;
        }

        public string subscriptions_url
        {
            get;
            set;
        }

        public string organizations_url
        {
            get;
            set;
        }

        public string repos_url
        {
            get;
            set;
        }

        public string events_url
        {
            get;
            set;
        }

        public string received_events_url
        {
            get;
            set;
        }

        public string type
        {
            get;
            set;
        }

        public bool site_admin
        {
            get;
            set;
        }
    }

    public class _Links1
    {
        public Self1 self
        {
            get;
            set;
        }

        public Html1 html
        {
            get;
            set;
        }

        public Pull_Request2 pull_request
        {
            get;
            set;
        }
    }

    public class Self1
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Html1
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Pull_Request2
    {
        public string href
        {
            get;
            set;
        }
    }

    public class Commit
    {
        public string sha
        {
            get;
            set;
        }

        public Author author
        {
            get;
            set;
        }

        public string message
        {
            get;
            set;
        }

        public bool distinct
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }
    }

    public class Author
    {
        public string email
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
    }

    public class Org
    {
        public int id
        {
            get;
            set;
        }

        public string login
        {
            get;
            set;
        }

        public string gravatar_id
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string avatar_url
        {
            get;
            set;
        }
    }
}
