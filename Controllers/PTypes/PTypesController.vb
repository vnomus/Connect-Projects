Imports System
Imports Connect.DNN.Modules.Projects.Repositories
Imports Connect.DNN.Modules.Projects.Models.PTypes
Imports DotNetNuke.Common.Utilities
Imports DotNetNuke.Data

Namespace Controllers.PTypes

 Partial Public Class PTypesController

  Public Shared Function GetSelectionList(projectId As Integer) As List(Of PTypeSelect)
   Return CBO.FillCollection(Of PTypeSelect)(DataProvider.Instance().ExecuteReader("Connect_Projects_GetProjectTypeSelectionList", projectId))
  End Function

  Public Shared Function GetPTypes() As IEnumerable(Of PType)

   Dim repo As New PTypeRepository
   Return repo.Get()

  End Function

  Public Shared Function GetPType(typeId As Int32) As PType

   Dim repo As New PTypeRepository
   Return repo.GetById(typeId)

  End Function

  Public Shared Function AddPType(ByRef ptype As PTypeBase) As Integer

   Dim repo As New PTypeBaseRepository
   repo.Insert(ptype)
   Return ptype.TypeId

  End Function

  Public Shared Sub UpdatePType(ptype As PTypeBase)

   Dim repo As New PTypeBaseRepository
   repo.Update(ptype)

  End Sub

  Public Shared Sub DeletePType(ptype As PTypeBase)

   Dim repo As New PTypeBaseRepository
   repo.Delete(ptype)

  End Sub

 End Class
End Namespace

