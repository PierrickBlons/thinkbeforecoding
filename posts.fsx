[<AutoOpen>]
module Posts

#load "Categories.fsx"

open System

module Path =
  let (</>) x y = IO.Path.Combine(x,y)
  let root = __SOURCE_DIRECTORY__
  let out = root </> "out"

  let outPosts = out </> "posts"
  let posts = root </> "Posts"
  let media = root </> "public"
  let content = root </> "content"
  let categories = out </> "category"
  let outmedia = out </> "public"
  let outcontent = out </> "content"
  let feed = out </> "feed"
  let atom = feed </> "atom.xml"


type Post = {
    Name: string
    Title: string
    Category: Category 
    Date: DateTime
    Url: string}

let date s= DateTime.Parse(s)
let posts = [
    { Name="300677"
      Title="Back in the blogosphere  !"
      Category= Personal
      Date=date "2008-11-19T21:20:22Z"
      Url="2008/11/19/Back-in-the-blogosphere" }
    { Name="300709"
      Title="'Save' is not a feature anymore"
      Category= Design
      Date=date "2008-11-19T23:00:38Z"
      Url="2008/11/20/Save-is-not-a-feature-anymore" }
    { Name="301164"
      Title="Must know English to be a programmer ?"
      Category= Personal
      Date=date "2008-11-21T13:55:36Z"
      Url="2008/11/21/Must-know-English-to-be-a-programmer" }
    { Name="302178"
      Title="Do you understand what it is all about ?"
      Category= Design
      Date=date "2008-11-24T14:37:26Z"
      Url="2008/11/24/Do-you-understand-what-it-is-all-about" }
    { Name="302189"
      Title="Coincidences just happen..."
      Category= Design
      Date=date "2008-11-24T14:51:47Z"
      Url="2008/11/24/Coincidences-just-happen" }
    { Name="302518"
      Title="CSS is too Tricky"
      Category= Design
      Date=date "2008-11-25T15:47:49Z"
      Url="2008/11/25/CSS-is-too-Tricky" }
    { Name="304478"
      Title="Ubiquity of language... lost in translation ?"
      Category= DomainDrivenDesign
      Date=date "2008-12-01T09:49:41Z"
      Url="2008/12/01/Ubiquity-of-language-lost-in-translation" }
    { Name="304576"
      Title="Problem with the Select N+1 problem"
      Category= Design
      Date=date "2008-12-01T15:17:04Z"
      Url="2008/12/01/Problem-with-the-Select-N1-problem" }
    { Name="304857"
      Title="Domain Driven Design"
      Category= DomainDrivenDesign
      Date=date "2008-12-02T13:41:52Z"
      Url="2008/12/02/Domain-Driven-Design" }
    { Name="307211"
      Title="Wow - Book review - Domain Driven Design!"
      Category= DomainDrivenDesign
      Date=date "2008-12-10T11:46:02Z"
      Url="2008/12/10/Wow-Book-review-Domain-Driven-Design" }
    { Name="310542"
      Title="Coding and writing - The form"
      Category= Design
      Date=date "2008-12-19T15:26:43Z"
      Url="2008/12/19/Coding-and-writing-The-form" }
    { Name="311459"
      Title="DDD: Specifications"
      Category= DomainDrivenDesign
      Date=date "2008-12-22T15:42:41Z"
      Url="2008/12/22/DDD:-Specifications" }
    { Name="311951"
      Title="Data Structures and Algorithms"
      Category= NetFramework
      Date=date "2008-12-24T10:05:06Z"
      Url="2008/12/24/Data-Structures-and-Algorithms" }
    { Name="312984"
      Title="Asp.Net authentication cookie oddities..."
      Category= AspNet
      Date=date "2008-12-29T17:24:12Z"
      Url="2008/12/29/AspNet-authentication-cookie-oddities" }
    { Name="315926"
      Title="Asp.net MVC binding security issue"
      Category= AspNet
      Date=date "2009-01-08T16:58:04Z"
      Url="2009/01/08/Aspnet-MVC-binding-security-issue" }
    { Name="318992"
      Title="Repositories and IQueryable, the paging case."
      Category= DomainDrivenDesign
      Date=date "2009-01-19T10:50:56Z"
      Url="2009/01/19/Repositories-and-IQueryable-the-paging-case" }
    { Name="319646"
      Title="Mixing IEnumerable and IQueryable"
      Category= DomainDrivenDesign
      Date=date "2009-01-21T16:12:22Z"
      Url="2009/01/21/Mixing-IEnumerable-and-IQueryable" }
    { Name="324887"
      Title="Lazy load and persistence ignorance"
      Category= DomainDrivenDesign
      Date=date "2009-02-07T13:44:51Z"
      Url="2009/02/07/Lazy-load-and-persistence-ignorance" }
    { Name="325085"
      Title="Lazy loads and persistence ignorance (Part 2)"
      Category= DomainDrivenDesign
      Date=date "2009-02-08T12:17:31Z"
      Url="2009/02/08/Lazy-loads-and-persistence-ignorance-Part-2" }
    { Name="328237"
      Title="Implement Linq to Objects in C# 2.0"
      Category= Linq
      Date=date "2009-02-17T14:55:15Z"
      Url="2009/02/17/Implement-Linq-to-Objects-in-CSharp-2" }
    { Name="329641"
      Title="Maintenance"
      Category= NoCategory
      Date=date "2009-02-22T22:31:05Z"
      Url="2009/02/22/Maintenance" }
    { Name="329682"
      Title="Back on track"
      Category= NoCategory
      Date=date "2009-02-23T08:55:26Z"
      Url="2009/02/23/Back-on-track" }
    { Name="330082"
      Title="Domain Driven Design Step By Step"
      Category= DomainDrivenDesign
      Date=date "2009-02-24T14:57:58Z"
      Url="2009/02/24/Domain-Driven-Design-Step-By-Step" }
    { Name="332903"
      Title="How *not* to inject services in entities"
      Category= DomainDrivenDesign
      Date=date "2009-03-04T15:01:53Z"
      Url="2009/03/04/How-not-to-inject-services-in-entities" }
    { Name="336213"
      Title="QCon London 2009"
      Category= DomainDrivenDesign
      Date=date "2009-03-12T15:21:23Z"
      Url="2009/03/12/QCon-London-2009" }
    { Name="391703"
      Title="Back on Repositories and Paging. Introducing reporting."
      Category= DomainDrivenDesign
      Date=date "2009-04-08T12:10:43Z"
      Url="2009/04/08/Back-on-Repositories-and-Paging-Introducing-reporting" }
    { Name="395293"
      Title="TDD becomes Design By Example"
      Category= Agile
      Date=date "2009-04-18T08:22:08Z"
      Url="2009/04/18/TDD-becomes-Design-By-Example" }
    { Name="398045"
      Title="Geek balance... or not !"
      Category= Personal
      Date=date "2009-04-28T21:04:53Z"
      Url="2009/04/28/Geek-balancehellip-or-not" }
    { Name="398049"
      Title="Strategic Design"
      Category= DomainDrivenDesign
      Date=date "2009-04-28T21:34:37Z"
      Url="2009/04/28/Strategic-Design" }
    { Name="400305"
      Title="Decimal, what are those trailing zeros ?"
      Category= NetFramework
      Date=date "2009-05-07T10:24:17Z"
      Url="2009/05/07/Decimal-what-are-those-trailing-zeros" }
    { Name="402298"
      Title="IOC Container, Go Hide !"
      Category= Design
      Date=date "2009-05-15T10:10:28Z"
      Url="2009/05/15/IOC-container-go-hide" }
    { Name="403632"
      Title="IOC Container, Go Hide (part 2)"
      Category= Design
      Date=date "2009-05-19T13:29:11Z"
      Url="2009/05/19/IOC-Container-Go-Hide-part-2" }
    { Name="410719"
      Title="Met Eric Evans at ParisJug"
      Category= DomainDrivenDesign
      Date=date "2009-06-16T21:58:28Z"
      Url="2009/06/16/Met-Eric-Evans-at-ParisJug" }
    { Name="410723"
      Title="When DDD should be considered ?"
      Category= DomainDrivenDesign
      Date=date "2009-06-16T22:11:23Z"
      Url="2009/06/17/When-DDD-should-be-considered" }
    { Name="410849"
      Title="Which model is best ? Thats not the question."
      Category= DomainDrivenDesign
      Date=date "2009-06-17T13:56:52Z"
      Url="2009/06/17/Which-model-is-best-Thats-not-the-question" }
    { Name="411792"
      Title="Strategic Design at DDD Exchange"
      Category= DomainDrivenDesign
      Date=date "2009-06-19T12:05:27Z"
      Url="2009/06/19/Strategic-Design-at-DDD-Exchange" }
    { Name="412806"
      Title="Where are my Entities and my Repositories ?"
      Category= DomainDrivenDesign
      Date=date "2009-06-23T12:20:11Z"
      Url="2009/06/23/Where-are-my-Entities-and-my-Repositories" }
    { Name="412868"
      Title="Distributed Domain Driven Design and Aggregates"
      Category= DomainDrivenDesign
      Date=date "2009-06-23T14:59:07Z"
      Url="2009/06/23/Distributed-Domain-Driven-Design-and-Aggregates" }
    { Name="420748"
      Title="DDD and Code ReUse"
      Category= DomainDrivenDesign
      Date=date "2009-07-24T14:34:22Z"
      Url="2009/07/24/DDD-and-Code-ReUse" }
    { Name="453105"
      Title="C# Static interfaces"
      Category= NetFramework
      Date=date "2009-10-21T12:46:26Z"
      Url="2009/10/21/CSharp-Static-interfaces" }
    { Name="453399"
      Title="C# Static interfaces - Take 2"
      Category= NetFramework
      Date=date "2009-10-22T13:11:07Z"
      Url="2009/10/22/CSharp-Static-interfaces-Take-2" }
    { Name="455931"
      Title="Uniqueness validation in CQRS Architecture"
      Category= DomainDrivenDesign
      Date=date "2009-10-28T14:05:36Z"
      Url="2009/10/28/Uniqueness-validation-in-CQRS-Architecture" }
    { Name="456396"
      Title="Event Sourcing and CQRS, Now !"
      Category= DomainDrivenDesign
      Date=date "2009-10-30T14:53:50Z"
      Url="2009/10/30/Event-Sourcing-and-CQRS-Now" }
    { Name="457100"
      Title="Event Sourcing and CQRS, Let's use it."
      Category= DomainDrivenDesign
      Date=date "2009-11-02T14:45:16Z"
      Url="2009/11/02/Event-Sourcing-and-CQRS-Lets-use-it" }
    { Name="457356"
      Title="Event Sourcing and CQRS, Dispatch options."
      Category= DomainDrivenDesign
      Date=date "2009-11-03T14:41:10Z"
      Url="2009/11/03/Event-Sourcing-and-CQRS-Dispatch-options" }
    { Name="457791"
      Title="Event Sourcing and CQRS, Serialization"
      Category= DomainDrivenDesign
      Date=date "2009-11-05T13:00:38Z"
      Url="2009/11/05/Event-Sourcing-and-CQRS-Serialization" }
    { Name="460191"
      Title="Udi Dahan talks on CQRS at Zenika"
      Category= DomainDrivenDesign
      Date=date "2009-11-16T10:08:51Z"
      Url="2009/11/16/Udi-Dahan-talks-on-CQRS-at-Zenika" }
    { Name="460508"
      Title="Udi Dahan talks on CQRS in Paris"
      Category= DomainDrivenDesign
      Date=date "2009-11-17T15:37:23Z"
      Url="2009/11/17/Udi-Dahan-talks-on-CQRS-in-Paris" }
    { Name="466789"
      Title="Udi Dahan's post on CQRS"
      Category= DomainDrivenDesign
      Date=date "2009-12-10T09:15:48Z"
      Url="2009/12/10/Udi-Dahan-post-on-CQRS" }
    { Name="466830"
      Title="Business Errors are Just Ordinary Events"
      Category= DomainDrivenDesign
      Date=date "2009-12-10T13:31:24Z"
      Url="2009/12/10/Business-Errors-are-Just-Ordinary-Events" }
    { Name="489754"
      Title="Event Sourcing and CQRS, Snapshots !"
      Category= DomainDrivenDesign
      Date=date "2010-02-25T09:38:23Z"
      Url="2010/02/25/Event-Sourcing-and-CQRS-Snapshots" }
    { Name="509715"
      Title="Event Sourcing and CQRS, Bounded Contexts"
      Category= DomainDrivenDesign
      Date=date "2010-04-17T13:21:42Z"
      Url="2010/04/17/Event-Sourcing-and-CQRS-Bounded-Contexts" }
    { Name="511514"
      Title="Event Sourcing and CQRS, Events Deserialization"
      Category= DomainDrivenDesign
      Date=date "2010-04-25T20:51:14Z"
      Url="2010/04/25/Event-Sourcing-and-CQRS-Events-Deserialization" }
    { Name="526729"
      Title="DDD Exchange 2010"
      Category= DomainDrivenDesign
      Date=date "2010-06-14T08:58:29Z"
      Url="2010/06/14/DDD-Exchange-2010" }
    { Name="555499"
      Title="Duck : Delete Update Create Killer"
      Category= Duck
      Date=date "2010-10-18T23:49:18Z"
      Url="2010/10/19/Duck-Delete-Update-Create-Killer" }
    { Name="579053"
      Title="Code code code"
      Category= NetFramework
      Date=date "2011-01-20T11:07:57Z"
      Url="2011/01/20/Code-code-code" }
    { Name="579381"
      Title="SmtpListener"
      Category= NetFramework
      Date=date "2011-01-21T13:45:00Z"
      Url="2011/01/21/SmtpListener" }
    { Name="579982"
      Title="Switching keyboard language in WP7"
      Category= WP7
      Date=date "2011-01-24T10:36:24Z"
      Url="2011/01/24/Switching-keyboard-language-in-WP7" }
    { Name="612637"
      Title="Time"
      Category= DomainDrivenDesign
      Date=date "2011-06-08T22:54:17Z"
      Url="2011/06/09/Time" }
    { Name="613679"
      Title="DDDx 2011"
      Category= DomainDrivenDesign
      Date=date "2011-06-14T08:30:46Z"
      Url="2011/06/14/DDDx-2011" }
    { Name="615066"
      Title="Event Sourcing and CQRS, Dispatch options 2"
      Category= DomainDrivenDesign
      Date=date "2011-06-21T08:38:57Z"
      Url="2011/06/21/Event-Sourcing-and-CQRS,-Dispatch-options-2" }
    { Name="653120"
      Title="I love SQL Server and cultures... NOT !"
      Category= NetFramework
      Date=date "2011-12-02T10:14:15Z"
      Url="2011/12/02/I-love-SQL-Server-and-cultures-NOT" }
    { Name="668343"
      Title="NuRep your local NuGet+symbols+source repository"
      Category= NuRep
      Date=date "2012-02-26T10:25:03Z"
      Url="2012/02/26/NuRep-your-local-NuGetsymbolssource-repository" }
    { Name="669709"
      Title="Caching done right"
      Category= CQRS
      Date=date "2012-03-05T12:49:38Z"
      Url="2012/03/05/Caching-done-right" }
    { Name="685921"
      Title="Make it simpler : get rid of Mocking Fx"
      Category= Design
      Date=date "2012-06-14T12:32:45Z"
      Url="2012/06/14/Make-it-simpler-:-get-rid-of-Mocking-Fx" }
    { Name="687197"
      Title="SimpleCQRS the F# version"
      Category= CQRS
      Date=date "2012-06-21T21:57:27Z"
      Url="2012/06/21/SimpleCQRS-the-F-version" }
    { Name="723115"
      Title="Entities and Repository injection - follow up"
      Category= DomainDrivenDesign
      Date=date "2013-03-03T21:27:37Z"
      Url="2013/03/03/Entities-and-Repository-injection-ndash;-follow-up" }
    { Name="727783"
      Title="Time is Money! DevoxxFr"
      Category= NoCategory
      Date=date "2013-04-03T08:24:43Z"
      Url="2013/04/03/Time-is-Money!-DevoxxFr" }
    { Name="727925"
      Title="C# Static interfaces - Take 3"
      Category= FSharp
      Date=date "2013-04-03T22:09:52Z"
      Url="2013/04/04/C-Static-interfaces-Take-3" }
    { Name="728018"
      Title="C# Static interfaces - Take 3 - redirect"
      Category= FSharp
      Date=date "2013-04-04T12:37:56Z"
      Url="2013/04/04/C-Static-interfaces-ndash;-Take-3" }
    { Name="743879"
      Title="Event Sourcing vs Command Sourcing"
      Category= EventSourcing
      Date=date "2013-07-27T23:00:11Z"
      Url="2013/07/28/Event-Sourcing-vs-Command-Sourcing" }
    { Name="743944"
      Title="Command Events and Context"
      Category= DomainDrivenDesign
      Date=date "2013-07-28T22:12:13Z"
      Url="2013/07/29/Command-Events-and-Context" }
    { Name="761913"
      Title="Generalized Conway's law"
      Category= Design
      Date=date "2013-12-17T09:09:51Z"
      Url="2013/12/17/Generalized-Conway-s-law" }
    { Name="764043"
      Title="Event Sourcing. Draw it"
      Category= NoCategory
      Date=date "2014-01-04T21:58:05Z"
      Url="2014/01/04/Event-Sourcing.-Draw-it" }
    { Name="778381"
      Title="Monoidal Event Sourcing"
      Category= EventSourcing
      Date=date "2014-04-11T02:34:48Z"
      Url="2014/04/11/Monoidal-Event-Sourcing" }
    { Name="780181"
      Title="Monoidal Event Sourcing Examples"
      Category= EventSourcing
      Date=date "2014-04-27T00:16:49Z"
      Url="2014/04/27/Monoidal-Event-Sourcing-Examples" }
    { Name="805275"
      Title="Speaking computers for more fun !"
      Category= FSharp
      Date=date "2014-12-23T10:17:32Z"
      Url="2014/12/23/Speaking-computers-for-more-fun-!" }
    { Name="Ukulele"
      Title="Ukulele Fun for XMas !"
      Category= FSharp
      Date=date "2015-12-17T09:44:43Z"
      Url="2015/12/17/Ukulele-Fun-for-XMas-!" }
    { Name="fck"
      Title="fck: Fake Construction Kit"
      Category= FSharp
      Date=date "2016-12-04T09:34:56Z"
      Url="2016/12/04/fck:-Fake-Construction-Kit" }
    { Name="back"
      Title="Back to blogging"
      Category = Category.Personal
      Date=date "2018-01-20T22:04:08Z"
      Url="2018/01/20/back-to-blogging" }
    { Name="functionalcore"
      Title="Functional Core"
      Category = Category.Design
      Date=date "2018-01-25T21:41:12Z"
      Url="2018/01/20/functional-core" }
    { Name="functionalcore2"
      Title="Functional Core - Part 2"
      Category = Category.Design
      Date=date "2018-02-01T21:09:13Z"
      Url="2018/02/01/functional-core-2" }
    { Name="information-space-time"
      Title="Information Space-Time"
      Category = Category.Design
      Date=date "2018-03-11T14:33:56Z"
      Url="2018/03/11/information-space-time" }
    { Name="openfsharp-2018"
      Title="OpenFSharp 2018"
      Category = Category.FSharp
      Date=date "2018-09-28T21:14:46Z"
      Url="2018/09/28/openfsharp-2018" }
]

