// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;

namespace Azure.Communication.JobRouter
{
    /// <summary> Model factory for models. </summary>
    public static partial class JobRouterModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="JobRouter.DistributionPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a distribution policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="offerExpiresAfter"> Number of seconds after which any offers created under this policy will be expired. </param>
        /// <param name="mode"> Mode governing the specific distribution method. </param>
        /// <returns> A new <see cref="JobRouter.DistributionPolicy"/> instance for mocking. </returns>
        public static DistributionPolicy DistributionPolicy(ETag eTag = default, string id = null, string name = null, TimeSpan? offerExpiresAfter = null, DistributionMode mode = null)
        {
            return new DistributionPolicy(
                eTag,
                id,
                name,
                offerExpiresAfter,
                mode,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ClassificationPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of a classification policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="fallbackQueueId"> Id of a fallback queue to select if queue selector attachments doesn't find a match. </param>
        /// <param name="queueSelectorAttachments"> Queue selector attachments used to resolve a queue for a job. </param>
        /// <param name="prioritizationRule"> A rule to determine a priority score for a job. </param>
        /// <param name="workerSelectorAttachments"> Worker selector attachments used to attach worker selectors to a job. </param>
        /// <returns> A new <see cref="JobRouter.ClassificationPolicy"/> instance for mocking. </returns>
        public static ClassificationPolicy ClassificationPolicy(ETag eTag = default, string id = null, string name = null, string fallbackQueueId = null, IEnumerable<QueueSelectorAttachment> queueSelectorAttachments = null, RouterRule prioritizationRule = null, IEnumerable<WorkerSelectorAttachment> workerSelectorAttachments = null)
        {
            queueSelectorAttachments ??= new List<QueueSelectorAttachment>();
            workerSelectorAttachments ??= new List<WorkerSelectorAttachment>();

            return new ClassificationPolicy(
                eTag,
                id,
                name,
                fallbackQueueId,
                queueSelectorAttachments?.ToList(),
                prioritizationRule,
                workerSelectorAttachments?.ToList(),
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionPolicy"/>. </summary>
        /// <param name="eTag"> The entity tag for this resource. </param>
        /// <param name="id"> Id of an exception policy. </param>
        /// <param name="name"> Friendly name of this policy. </param>
        /// <param name="exceptionRules"> A collection of exception rules on the exception policy. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionPolicy"/> instance for mocking. </returns>
        public static ExceptionPolicy ExceptionPolicy(ETag eTag = default, string id = null, string name = null, IEnumerable<ExceptionRule> exceptionRules = null)
        {
            exceptionRules ??= new List<ExceptionRule>();

            return new ExceptionPolicy(eTag, id, name, exceptionRules?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionRule"/>. </summary>
        /// <param name="id"> Id of an exception rule. </param>
        /// <param name="trigger"> The trigger for this exception rule. </param>
        /// <param name="actions"> A collection of actions to perform once the exception is triggered. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionRule"/> instance for mocking. </returns>
        public static ExceptionRule ExceptionRule(string id = null, ExceptionTrigger trigger = null, IEnumerable<ExceptionAction> actions = null)
        {
            actions ??= new List<ExceptionAction>();

            return new ExceptionRule(id, trigger, actions?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ExceptionAction"/>. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="kind"> The type discriminator describing a sub-type of ExceptionAction. </param>
        /// <returns> A new <see cref="JobRouter.ExceptionAction"/> instance for mocking. </returns>
        public static ExceptionAction ExceptionAction(string id = null, string kind = "Unknown")
        {
            return new UnknownExceptionAction(id, kind, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of a job assignment. </param>
        /// <param name="workerId"> Id of the Worker assigned to the job. </param>
        /// <param name="assignedAt"> Timestamp when the job was assigned to a worker in UTC. </param>
        /// <param name="completedAt"> Timestamp when the job was marked as completed after being assigned in UTC. </param>
        /// <param name="closedAt"> Timestamp when the job was marked as closed after being completed in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobAssignment"/> instance for mocking. </returns>
        public static RouterJobAssignment RouterJobAssignment(string assignmentId = null, string workerId = null, DateTimeOffset assignedAt = default, DateTimeOffset? completedAt = null, DateTimeOffset? closedAt = null)
        {
            return new RouterJobAssignment(
                assignmentId,
                workerId,
                assignedAt,
                completedAt,
                closedAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobNote"/>. </summary>
        /// <param name="message"> The message contained in the note. </param>
        /// <param name="addedAt"> The time at which the note was added in UTC. If not provided, will default to the current time. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobNote"/> instance for mocking. </returns>
        public static RouterJobNote RouterJobNote(string message = null, DateTimeOffset? addedAt = null)
        {
            return new RouterJobNote(message, addedAt, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobPositionDetails"/>. </summary>
        /// <param name="jobId"> Id of the job these details are about. </param>
        /// <param name="position"> Position of the job in question within that queue. </param>
        /// <param name="queueId"> Id of the queue this job is enqueued in. </param>
        /// <param name="queueLength"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTime"> Estimated wait time of the job rounded up to the nearest minute. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobPositionDetails"/> instance for mocking. </returns>
        public static RouterJobPositionDetails RouterJobPositionDetails(string jobId = null, int position = default, string queueId = null, int queueLength = default, TimeSpan estimatedWaitTime = default)
        {
            return new RouterJobPositionDetails(
                jobId,
                position,
                queueId,
                queueLength,
                estimatedWaitTime,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.UnassignJobResult"/>. </summary>
        /// <param name="jobId"> Id of an unassigned job. </param>
        /// <param name="unassignmentCount"> The number of times a job is unassigned. At a maximum 3. </param>
        /// <returns> A new <see cref="JobRouter.UnassignJobResult"/> instance for mocking. </returns>
        public static UnassignJobResult UnassignJobResult(string jobId = null, int unassignmentCount = default)
        {
            return new UnassignJobResult(jobId, unassignmentCount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.AcceptJobOfferResult"/>. </summary>
        /// <param name="assignmentId"> Id of job assignment that assigns a worker that has accepted an offer to a job. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="workerId"> Id of the worker that has been assigned this job. </param>
        /// <returns> A new <see cref="JobRouter.AcceptJobOfferResult"/> instance for mocking. </returns>
        public static AcceptJobOfferResult AcceptJobOfferResult(string assignmentId = null, string jobId = null, string workerId = null)
        {
            return new AcceptJobOfferResult(assignmentId, jobId, workerId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterQueueStatistics"/>. </summary>
        /// <param name="queueId"> Id of the queue these details are about. </param>
        /// <param name="length"> Length of the queue: total number of enqueued jobs. </param>
        /// <param name="estimatedWaitTimes"> The estimated wait time of this queue rounded up to the nearest minute, grouped by job priority. </param>
        /// <param name="longestJobWaitTimeMinutes"> The wait time of the job that has been enqueued in this queue for the longest. </param>
        /// <returns> A new <see cref="JobRouter.RouterQueueStatistics"/> instance for mocking. </returns>
        public static RouterQueueStatistics RouterQueueStatistics(string queueId = null, int length = default, IDictionary<int, TimeSpan> estimatedWaitTimes = null, double? longestJobWaitTimeMinutes = null)
        {
            estimatedWaitTimes ??= new Dictionary<int, TimeSpan>();

            return new RouterQueueStatistics(queueId, length, estimatedWaitTimes, longestJobWaitTimeMinutes, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterChannel"/>. </summary>
        /// <param name="channelId"> Id of a channel. </param>
        /// <param name="capacityCostPerJob"> The amount of capacity that an instance of a job of this channel will consume of the total worker capacity. </param>
        /// <param name="maxNumberOfJobs"> The maximum number of jobs that can be supported concurrently for this channel. </param>
        /// <returns> A new <see cref="JobRouter.RouterChannel"/> instance for mocking. </returns>
        public static RouterChannel RouterChannel(string channelId = null, int capacityCostPerJob = default, int? maxNumberOfJobs = null)
        {
            return new RouterChannel(channelId, capacityCostPerJob, maxNumberOfJobs, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterJobOffer"/>. </summary>
        /// <param name="offerId"> Id of an offer. </param>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> Timestamp when the offer was created in UTC. </param>
        /// <param name="expiresAt"> Timestamp when the offer will expire in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterJobOffer"/> instance for mocking. </returns>
        public static RouterJobOffer RouterJobOffer(string offerId = null, string jobId = null, int capacityCost = default, DateTimeOffset? offeredAt = null, DateTimeOffset? expiresAt = null)
        {
            return new RouterJobOffer(
                offerId,
                jobId,
                capacityCost,
                offeredAt,
                expiresAt,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RouterWorkerAssignment"/>. </summary>
        /// <param name="assignmentId"> Id of the assignment. </param>
        /// <param name="jobId"> Id of the job assigned. </param>
        /// <param name="capacityCost"> The amount of capacity this assignment has consumed on the worker. </param>
        /// <param name="assignedAt"> The assignment time of the job in UTC. </param>
        /// <returns> A new <see cref="JobRouter.RouterWorkerAssignment"/> instance for mocking. </returns>
        public static RouterWorkerAssignment RouterWorkerAssignment(string assignmentId = null, string jobId = null, int capacityCost = default, DateTimeOffset assignedAt = default)
        {
            return new RouterWorkerAssignment(assignmentId, jobId, capacityCost, assignedAt, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ScheduleAndSuspendMode"/>. </summary>
        /// <param name="scheduleAt"> Requested schedule time. </param>
        /// <returns> A new <see cref="JobRouter.ScheduleAndSuspendMode"/> instance for mocking. </returns>
        public static ScheduleAndSuspendMode ScheduleAndSuspendMode(DateTimeOffset scheduleAt = default)
        {
            return new ScheduleAndSuspendMode(JobMatchingModeKind.ScheduleAndSuspend, serializedAdditionalRawData: null, scheduleAt);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.CancelExceptionAction"/>. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="note"> A note that will be appended to a job's notes collection with the current timestamp. </param>
        /// <param name="dispositionCode"> Indicates the outcome of a job, populate this field with your own custom values. </param>
        /// <returns> A new <see cref="JobRouter.CancelExceptionAction"/> instance for mocking. </returns>
        public static CancelExceptionAction CancelExceptionAction(string id = null, string note = null, string dispositionCode = null)
        {
            return new CancelExceptionAction(id, ExceptionActionKind.Cancel, serializedAdditionalRawData: null, note, dispositionCode);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ConditionalQueueSelectorAttachment"/>. </summary>
        /// <param name="condition"> The condition that must be true for the queue selectors to be attached. </param>
        /// <param name="queueSelectors"> The queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalQueueSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalQueueSelectorAttachment ConditionalQueueSelectorAttachment(RouterRule condition = null, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new ConditionalQueueSelectorAttachment(QueueSelectorAttachmentKind.Conditional, serializedAdditionalRawData: null, condition, queueSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/>. </summary>
        /// <param name="condition"> The condition that must be true for the worker selectors to be attached. </param>
        /// <param name="workerSelectors"> The worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.ConditionalWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static ConditionalWorkerSelectorAttachment ConditionalWorkerSelectorAttachment(RouterRule condition = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ConditionalWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Conditional, serializedAdditionalRawData: null, condition, workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.FunctionRouterRule"/>. </summary>
        /// <param name="functionUri"> URL for Azure Function. </param>
        /// <param name="credential"> Credentials used to access Azure function rule. </param>
        /// <returns> A new <see cref="JobRouter.FunctionRouterRule"/> instance for mocking. </returns>
        public static FunctionRouterRule FunctionRouterRule(Uri functionUri = null, FunctionRouterRuleCredential credential = null)
        {
            return new FunctionRouterRule(RouterRuleKind.Function, serializedAdditionalRawData: null, functionUri, credential);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.ManualReclassifyExceptionAction"/>. </summary>
        /// <param name="id"> Unique Id of the exception action. </param>
        /// <param name="queueId"> Updated QueueId. </param>
        /// <param name="priority"> Updated Priority. </param>
        /// <param name="workerSelectors"> Updated WorkerSelectors. </param>
        /// <returns> A new <see cref="JobRouter.ManualReclassifyExceptionAction"/> instance for mocking. </returns>
        public static ManualReclassifyExceptionAction ManualReclassifyExceptionAction(string id = null, string queueId = null, int? priority = null, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new ManualReclassifyExceptionAction(
                id,
                ExceptionActionKind.ManualReclassify,
                serializedAdditionalRawData: null,
                queueId,
                priority,
                workerSelectors?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.PassThroughQueueSelectorAttachment"/>. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughQueueSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughQueueSelectorAttachment PassThroughQueueSelectorAttachment(string key = null, LabelOperator labelOperator = default)
        {
            return new PassThroughQueueSelectorAttachment(QueueSelectorAttachmentKind.PassThrough, serializedAdditionalRawData: null, key, labelOperator);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/>. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value pass through. </param>
        /// <param name="expiresAfter"> Describes how long the attached label selector is valid in seconds. </param>
        /// <returns> A new <see cref="JobRouter.PassThroughWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static PassThroughWorkerSelectorAttachment PassThroughWorkerSelectorAttachment(string key = null, LabelOperator labelOperator = default, TimeSpan? expiresAfter = null)
        {
            return new PassThroughWorkerSelectorAttachment(WorkerSelectorAttachmentKind.PassThrough, serializedAdditionalRawData: null, key, labelOperator, expiresAfter);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.QueueLengthExceptionTrigger"/>. </summary>
        /// <param name="threshold"> Threshold of number of jobs ahead in the queue to for this trigger to fire. </param>
        /// <returns> A new <see cref="JobRouter.QueueLengthExceptionTrigger"/> instance for mocking. </returns>
        public static QueueLengthExceptionTrigger QueueLengthExceptionTrigger(int threshold = default)
        {
            return new QueueLengthExceptionTrigger(ExceptionTriggerKind.QueueLength, serializedAdditionalRawData: null, threshold);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.QueueWeightedAllocation"/>. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="queueSelectors"> A collection of queue selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.QueueWeightedAllocation"/> instance for mocking. </returns>
        public static QueueWeightedAllocation QueueWeightedAllocation(double weight = default, IEnumerable<RouterQueueSelector> queueSelectors = null)
        {
            queueSelectors ??= new List<RouterQueueSelector>();

            return new QueueWeightedAllocation(weight, queueSelectors?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/>. </summary>
        /// <param name="rule"> A RouterRule that resolves a collection of queue selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineQueueSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineQueueSelectorAttachment RuleEngineQueueSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineQueueSelectorAttachment(QueueSelectorAttachmentKind.RuleEngine, serializedAdditionalRawData: null, rule);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/>. </summary>
        /// <param name="rule"> A RouterRule that resolves a collection of worker selectors to attach. </param>
        /// <returns> A new <see cref="JobRouter.RuleEngineWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static RuleEngineWorkerSelectorAttachment RuleEngineWorkerSelectorAttachment(RouterRule rule = null)
        {
            return new RuleEngineWorkerSelectorAttachment(WorkerSelectorAttachmentKind.RuleEngine, serializedAdditionalRawData: null, rule);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.StaticQueueSelectorAttachment"/>. </summary>
        /// <param name="queueSelector"> The queue selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticQueueSelectorAttachment"/> instance for mocking. </returns>
        public static StaticQueueSelectorAttachment StaticQueueSelectorAttachment(RouterQueueSelector queueSelector = null)
        {
            return new StaticQueueSelectorAttachment(QueueSelectorAttachmentKind.Static, serializedAdditionalRawData: null, queueSelector);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.StaticWorkerSelectorAttachment"/>. </summary>
        /// <param name="workerSelector"> The worker selector to attach. </param>
        /// <returns> A new <see cref="JobRouter.StaticWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static StaticWorkerSelectorAttachment StaticWorkerSelectorAttachment(RouterWorkerSelector workerSelector = null)
        {
            return new StaticWorkerSelectorAttachment(WorkerSelectorAttachmentKind.Static, serializedAdditionalRawData: null, workerSelector);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WebhookRouterRule"/>. </summary>
        /// <param name="authorizationServerUri"> Uri for Authorization Server. </param>
        /// <param name="clientCredential"> OAuth2.0 Credentials used to Contoso's Authorization server. Reference: https://www.oauth.com/oauth2-servers/access-tokens/client-credentials/. </param>
        /// <param name="webhookUri"> Uri for Contoso's Web Server. </param>
        /// <returns> A new <see cref="JobRouter.WebhookRouterRule"/> instance for mocking. </returns>
        public static WebhookRouterRule WebhookRouterRule(Uri authorizationServerUri = null, OAuth2WebhookClientCredential clientCredential = null, Uri webhookUri = null)
        {
            return new WebhookRouterRule(RouterRuleKind.Webhook, serializedAdditionalRawData: null, authorizationServerUri, clientCredential, webhookUri);
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/>. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationQueueSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationQueueSelectorAttachment WeightedAllocationQueueSelectorAttachment(IEnumerable<QueueWeightedAllocation> allocations = null)
        {
            allocations ??= new List<QueueWeightedAllocation>();

            return new WeightedAllocationQueueSelectorAttachment(QueueSelectorAttachmentKind.WeightedAllocation, serializedAdditionalRawData: null, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/>. </summary>
        /// <param name="allocations"> A collection of percentage based weighted allocations. </param>
        /// <returns> A new <see cref="JobRouter.WeightedAllocationWorkerSelectorAttachment"/> instance for mocking. </returns>
        public static WeightedAllocationWorkerSelectorAttachment WeightedAllocationWorkerSelectorAttachment(IEnumerable<WorkerWeightedAllocation> allocations = null)
        {
            allocations ??= new List<WorkerWeightedAllocation>();

            return new WeightedAllocationWorkerSelectorAttachment(WorkerSelectorAttachmentKind.WeightedAllocation, serializedAdditionalRawData: null, allocations?.ToList());
        }

        /// <summary> Initializes a new instance of <see cref="JobRouter.WorkerWeightedAllocation"/>. </summary>
        /// <param name="weight"> The percentage of this weight, expressed as a fraction of 1. </param>
        /// <param name="workerSelectors"> A collection of worker selectors that will be applied if this allocation is selected. </param>
        /// <returns> A new <see cref="JobRouter.WorkerWeightedAllocation"/> instance for mocking. </returns>
        public static WorkerWeightedAllocation WorkerWeightedAllocation(double weight = default, IEnumerable<RouterWorkerSelector> workerSelectors = null)
        {
            workerSelectors ??= new List<RouterWorkerSelector>();

            return new WorkerWeightedAllocation(weight, workerSelectors?.ToList(), serializedAdditionalRawData: null);
        }
    }
}
