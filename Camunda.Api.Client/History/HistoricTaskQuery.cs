using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camunda.Api.Client.History
{
    public class HistoricTaskQuery : SortableQuery<HistoricTaskQuerySorting, HistoricTaskQuery>
    {
        /// <summary>
        /// Filter by task id.
        /// </summary>
        public string TaskId { get; set; }
        /// <summary>
        /// Filter by parent task id.
        /// </summary>
        public string TaskParentTaskId { get; set; }
        /// <summary>
        /// Filter by process instance id.
        /// </summary>
        public string ProcessInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the execution that executed the task.
        /// </summary>
        public string ExecutionId { get; set; }
        /// <summary>
        /// Filter by process definition id.
        /// </summary>
        public string ProcessDefinitionId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given key.
        /// </summary>
        public string ProcessDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a process definition with the given name.
        /// </summary>
        public string ProcessDefinitionName { get; set; }
        /// <summary>
        /// Filter by case instance id.
        /// </summary>
        public string CaseInstanceId { get; set; }
        /// <summary>
        /// Filter by the id of the case execution that executed the task.
        /// </summary>
        public string CaseExecutionId { get; set; }
        /// <summary>
        /// Filter by case definition id.
        /// </summary>
        public string CaseDefinitionId { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given key.
        /// </summary>
        public string CaseDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that belong to a case definition with the given name.
        /// </summary>
        public string CaseDefinitionName { get; set; }
        /// <summary>
        /// Only include tasks which belong to one of the passed and comma-separated activity instance ids.
        /// </summary>
        public string ActivityInstanceIdIn { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given name.
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// Restrict to tasks that have a name with the given parameter value as substring.
        /// </summary>
        public string TaskNameLike { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given description.
        /// </summary>
        public string TaskDescription { get; set; }
        /// <summary>
        /// Restrict to tasks that have a description that has the parameter value as a substring.
        /// </summary>
        public string TaskDescriptionLike { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given key.
        /// </summary>
        public string TaskDefinitionKey { get; set; }
        /// <summary>
        /// Restrict to tasks that have one of the passed and comma-separated task definition keys.
        /// </summary>
        public string TaskDefinitionKeyIn { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given delete reason.
        /// </summary>
        public string TaskDeleteReason { get; set; }
        /// <summary>
        /// Restrict to tasks that have a delete reason that has the parameter value as a substring.
        /// </summary>
        public string TaskDeleteReasonLike { get; set; }
        /// <summary>
        /// Restrict to tasks that the given user is assigned to.
        /// </summary>
        public string TaskAssignee { get; set; }
        /// <summary>
        /// Restrict to tasks that are assigned to users with the parameter value as a substring.
        /// </summary>
        public string TaskAssigneeLike { get; set; }
        /// <summary>
        /// Restrict to tasks that the given user owns.
        /// </summary>
        public string TaskOwner { get; set; }
        /// <summary>
        /// Restrict to tasks that are owned by users with the parameter value as a substring.
        /// </summary>
        public string TaskOwnerLike { get; set; }
        /// <summary>
        /// Restrict to tasks that have the given priority.
        /// </summary>
        public string TaskPriority { get; set; }
        /// <summary>
        /// If set to true, restricts the query to all tasks that are assigned.
        /// </summary>
        public string Assigned { get; set; }
        /// <summary>
        /// If set to true, restricts the query to all tasks that are unassigned.
        /// </summary>
        public string Unassigned { get; set; }
        /// <summary>
        /// Only include finished tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public string Finished { get; set; }
        /// <summary>
        /// Only include unfinished tasks. Value may only be true, as false is the default behavior.
        /// </summary>
        public string Unfinished { get; set; }
        /// <summary>
        /// Only include tasks of finished processes. Value may only be true, as false is the default behavior.
        /// </summary>
        public string ProcessFinished { get; set; }
        /// <summary>
        /// Only include tasks of unfinished processes. Value may only be true, as false is the default behavior.
        /// </summary>
        public string ProcessUnfinished { get; set; }
        /// <summary>
        /// Restrict to tasks that are due on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskDueDate { get; set; }
        /// <summary>
        /// Restrict to tasks that are due before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskDueDateBefore { get; set; }
        /// <summary>
        /// Restrict to tasks that are due after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskDueDateAfter { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date on the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskFollowUpDate { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date before the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskFollowUpDateBefore { get; set; }
        /// <summary>
        /// Restrict to tasks that have a followUp date after the given date. The date must have the format yyyy-MM-dd'T'HH:mm:ss, e.g., 2013-01-23T14:42:45.
        /// </summary>
        public string TaskFollowUpDateAfter { get; set; }
        /// <summary>
        /// Filter by a comma-separated list of tenant ids. A task instance must have one of the given tenant ids.
        /// </summary>
        public string TenantIdIn { get; set; }
        /// <summary>
        /// Only include tasks that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:
        ///     A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        ///     Note: Values are always treated as String objects on server side.
        ///
        ///     Valid operator values are: eq - equal to; neq - not equal to; gt - greater than; gteq - greater than or equal to; lt - lower than; lteq - lower than or equal to; like.
        ///     key and value may not contain underscore or comma characters.
        /// </summary>
        public string TaskVariables { get; set; }

        /// <summary>
        /// Only include tasks that belong to process instances that have variables with certain values. Variable filtering expressions are comma-separated and are structured as follows:
        ///     A valid parameter value has the form key_operator_value.key is the variable name, operator is the comparison operator to be used and value the variable value.
        ///     Note: Values are always treated as String objects on server side.
        ///     
        ///     Valid operator values are: eq - equal to; neq - not equal to; gt - greater than; gteq - greater than or equal to; lt - lower than; lteq - lower than or equal to; like.
        ///     key and value may not contain underscore or comma characters.
        /// </summary>
        public string ProcessVariables { get; set; }

        /// <summary>
        /// Restrict to tasks with a historic identity link to the given user.
        /// </summary>
        public string TaskInvolvedUser { get; set; }
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given group.
        /// </summary>
        public string TaskInvolvedGroup { get; set; }
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate user.
        /// </summary>
        public string TaskHadCandidateUser { get; set; }
        /// <summary>
        /// Restrict to tasks with a historic identity link to the given candidate group.
        /// </summary>
        public string TaskHadCandidateGroup { get; set; }
        /// <summary>
        /// Only include tasks which have a candidate group. Value may only be true, as false is the default behavior.
        /// </summary>
        public string WithCandidateGroups { get; set; }
        /// <summary>
        /// Only include tasks which have no candidate group. Value may only be true, as false is the default behavior.
        /// </summary>
        public string TithoutCandidateGroups { get; set; }
        /// <summary>
        /// Sort the results by a given criterion. Valid values are taskId, activityInstanceID, processDefinitionId, processInstanceId, executionId, duration, endTime, startTime, taskName, taskDescription, assignee, owner, dueDate, followUpDate, deleteReason, taskDefinitionKey, priority, caseDefinitionId, caseInstanceId, caseExecutionId and tenantId. Must be used in conjunction with the sortOrder parameter.
        /// </summary>
        public string SortBy { get; set; }
        /// <summary>
        /// Sort the results in a given order. Values may be asc for ascending order or desc for descending order. Must be used in conjunction with the sortBy parameter.
        /// </summary>
        public string SortOrder { get; set; }
        /// <summary>
        /// Pagination of results. Specifies the index of the first result to return.
        /// </summary>
        public string FirstResult { get; set; }
        /// <summary>
        /// Pagination of results. Specifies the maximum number of results to return. Will return less results if there are no more results left.
        /// </summary>
        public string MaxResults { get; set; }
    }

    public enum HistoricTaskQuerySorting
    {
        TaskId,
        ActivityInstanceID,
        ProcessDefinitionId,
        ProcessInstanceId,
        ExecutionId,
        Duration,
        EndTime,
        StartTime,
        TaskName,
        TaskDescription,
        Assignee,
        Owner,
        DueDate,
        FollowUpDate,
        DeleteReason,
        TaskDefinitionKey,
        Priority,
        CaseDefinitionId,
        CaseInstanceId,
        CaseExecutionId,
        TenantId,
    }
}
