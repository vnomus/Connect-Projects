Imports System.Runtime.Serialization
Imports Connect.DNN.Modules.Projects.Models.ProjectTags
Imports Connect.DNN.Modules.Projects.Models.PTypes
Imports Connect.DNN.Modules.Projects.Models.Urls
Imports DotNetNuke.ComponentModel.DataAnnotations

Namespace Models.Projects
 Partial Public Class Project

  <IgnoreColumn()>
  <DataMember()>
  Public Property ProjectTypes As List(Of PTypeSelect)

  <IgnoreColumn()>
  <DataMember()>
  Public Property SelectedProjectTypes As List(Of Integer)

  <IgnoreColumn()>
  <DataMember()>
  Public Property Urls As IEnumerable(Of UrlBase)

  <IgnoreColumn()>
  <DataMember()>
  Public Property ProjectTags As IEnumerable(Of ProjectTag)

 End Class
End Namespace


