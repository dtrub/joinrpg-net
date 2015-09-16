﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using JoinRpg.DataModel;

namespace JoinRpg.Web.Models.Plot
{
  public abstract class PlotFolderViewModelBase
  {
    [Required]
    public int ProjectId{ get; set; }

    [Required, Display(Name="Название сюжета")]
    public string PlotFolderMasterTitle{ get; set; }

    [Display(Name = "TODO (что сделать по сюжету)"), DataType(DataType.MultilineText)]
    public string TodoField
    { get; set; }

    protected static PlotStatus GetStatus(PlotFolder folder)
    {
      return folder.IsActive ? (folder.InWork ? PlotStatus.InWork : PlotStatus.Completed) : PlotStatus.Deleted;
    }

    [ReadOnly(true), Display(Name = "Статус")]
    public PlotStatus Status { get; set; }

    protected static PlotStatus GetStatus(PlotElement e)
    {
      return !e.IsActive ? PlotStatus.Deleted : (e.IsCompleted ? PlotStatus.Completed : PlotStatus.InWork);
    }
  }


  public enum PlotStatus
  {
    [Display(Name = "В работе")]
    InWork,
    [Display(Name = "Закончен")]
    Completed,
    [Display(Name = "Удален")]
    Deleted
  }
}