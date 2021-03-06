Imports System
Imports Connect.DNN.Modules.Projects.Repositories
Imports Connect.DNN.Modules.Projects.Models.Urls

Namespace Controllers.Urls

 Partial Public Class UrlsController

  Public Shared Function GetUrlsToCheck() As IEnumerable(Of UrlBase)

   Dim repo As New UrlBaseRepository
   Return repo.Find("WHERE Retries > 0")

  End Function

  Public Shared Sub SetProjectUrls(projectId As Integer, urls As IEnumerable(Of UrlBase))

   Dim existingUrls As New Dictionary(Of Integer, UrlBase)
   Dim newUrls As New List(Of UrlBase)
   For Each url As UrlBase In urls
    If url.UrlId = -1 Then
     newUrls.Add(url)
    Else
     existingUrls.Add(url.UrlId, url)
    End If
   Next

   Dim oldUrls As IEnumerable(Of UrlBase) = GetUrls(projectId)
   For Each oldUrl As UrlBase In oldUrls
    If existingUrls.ContainsKey(oldUrl.UrlId) Then
     If oldUrl.ProjectId = projectId Then ' make sure on one is hacking
      oldUrl.Url = existingUrls(oldUrl.UrlId).Url
      oldUrl.Description = existingUrls(oldUrl.UrlId).Description
      UpdateUrl(oldUrl)
     End If
    Else
     DeleteUrl(oldUrl)
    End If
   Next

   For Each newUrl As UrlBase In newUrls
    newUrl.ProjectId = projectId ' make sure on one is hacking
    AddUrl(newUrl)
   Next

  End Sub

  Public Shared Function GetUrls(projectId As Int32) As IEnumerable(Of UrlBase)

   Dim repo As New UrlBaseRepository
   Return repo.Find("WHERE ProjectId=@0", projectId)

  End Function

  Public Shared Function GetUrl(urlId As Int32) As Url

   Dim repo As New UrlRepository
   Return repo.GetById(urlId)

  End Function

  Public Shared Function AddUrl(ByRef url As UrlBase) As Integer

   Dim repo As New UrlBaseRepository
   repo.Insert(url)
   Return url.UrlId

  End Function

  Public Shared Sub UpdateUrl(url As UrlBase)

   Dim repo As New UrlBaseRepository
   repo.Update(url)

  End Sub

  Public Shared Sub DeleteUrl(url As UrlBase)

   Dim repo As New UrlBaseRepository
   repo.Delete(url)

  End Sub

 End Class
End Namespace

