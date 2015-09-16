﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JoinRpg.DataModel;

namespace JoinRpg.Data.Interfaces
{
  public interface IProjectRepository : IDisposable
  {
    Task<IEnumerable<Project>> GetActiveProjects();

    IEnumerable<Project> GetMyActiveProjects(int? userInfoId);

    Task<IEnumerable<Project>> GetMyActiveProjectsAsync(int? userInfoId);

    Project GetProject(int project);
    Task<Project> GetProjectAsync(int project);
    Task<Project> GetProjectWithDetailsAsync(int project);
    Task<CharacterGroup> LoadGroupAsync(int projectId, int characterGroupId);
    CharacterGroup GetCharacterGroup(int projectId, int groupId);
    Character GetCharacter(int projectId, int characterId);
    Claim GetClaim(int projectId, int claimId);
  }
}
