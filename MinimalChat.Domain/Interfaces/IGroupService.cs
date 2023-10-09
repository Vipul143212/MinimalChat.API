﻿using MinimalChat.Domain.DTOs;
using MinimalChat.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalChat.Domain.Interfaces
{
    public interface IGroupService
    {
        /// <summary>
        /// Asynchronously creates a new group based on the provided information.
        /// </summary>
        /// <param name="currentUser">The unique identifier of the user creating the group.</param>
        /// <param name="groupDto">Data transfer object containing information about the group.</param>
        /// <returns>
        ///   A task representing the asynchronous operation, with the created Group object.
        /// </returns>
        Task<Group> CreateGroupAsync(Guid currentUser, GroupDto groupDto);

        /// <summary>
        /// Asynchronously adds members to a specified group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the target group.</param>
        /// <param name="currentUserId">The unique identifier of the current user initiating the action.</param>
        /// <param name="memberIds">List of unique identifiers of members to be added to the group.</param>
        /// <returns>
        ///   A task representing the asynchronous operation, with a string result indicating the outcome.
        /// </returns>
        Task<string> AddMemberToGroupAsync(Guid groupId, Guid currentUserId, List<Guid> memberIds);

        /// <summary>
        /// Asynchronously removes a member from a specified group.
        /// </summary>
        /// <param name="groupId">The unique identifier of the target group.</param>
        /// <param name="currentUserId">The unique identifier of the current user initiating the action.</param>
        /// <param name="memberId">The unique identifier of the member to be removed from the group.</param>
        /// <returns>
        ///   A task representing the asynchronous operation, with a string result indicating the outcome.
        /// </returns>
        Task<string> RemoveMemberFromGroupAsync(Guid groupId, Guid currentUserId, Guid memberId);

        /// <summary>
        /// Edits the name of a group with the specified ID.
        /// </summary>
        /// <param name="groupId">The unique identifier of the group to edit.</param>
        /// <param name="newName">The new name to set for the group.</param>
        /// <returns>
        /// A task representing the asynchronous operation.
        /// The task result is a string message indicating the outcome of the operation.
        /// If successful, the message will indicate success.
        /// If the group is not found, the message will indicate that the group was not found.
        /// </returns>
        Task<string> EditGroupNameAsync(Guid groupId, string newName);
    }
}
