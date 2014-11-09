﻿// The model classes are generated by json2sharp.com (http://json2csharp.com/)

using System.Collections.Generic;

namespace UdemyDownloader
{
    public class DownloadUrl
    {
        public List<string> Video { get; set; }
        public List<string> Video480P { get; set; }
        public string Download { get; set; }
    }

    public class Dimensions
    {
        public int Height { get; set; }
        public int Width { get; set; }
    }

    public class Data
    {
        public string Name { get; set; }
        public string TicketId { get; set; }
        public int? IsHD { get; set; }
        public int? JobId { get; set; }
        public int? InputHeight { get; set; }
        public int? Duration { get; set; }
        public Dimensions Dimensions { get; set; }
        public string ProcessedThumbFileName { get; set; }
        public string GetVideoPlayerThumbmailFrom { get; set; }
    }

    public class Caption
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string FileName { get; set; }
        public string Locale { get; set; }
        public string Language { get; set; }
        public string Url { get; set; }
    }

    public class Asset
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContextInfo { get; set; }
        public string ThumbnailUrl { get; set; }
        public string StreamUrl { get; set; }
        public DownloadUrl DownloadUrl { get; set; }
        public Data Data { get; set; }
        public string Status { get; set; }
        public int RemainingProcessingTime { get; set; }
        public string ViewHTML { get; set; }
        public string Length { get; set; }
        public List<Caption> Captions { get; set; }
    }

    public class Images
    {
        public string Img_480_H { get; set; }
        public string Img_320_H { get; set; }
        public string Img_200_H { get; set; }
        public string Img_100_H { get; set; }
        public string Img_75_H { get; set; }
        public string Img_50_H { get; set; }
    }

    public class TimeEstimate
    {
        public double Duration { get; set; }
        public int Accuracy { get; set; }
    }

    public class PromoAsset
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ContextInfo { get; set; }
        public string ThumbnailUrl { get; set; }
        public string StreamUrl { get; set; }
        public DownloadUrl DownloadUrl { get; set; }
        public Data Data { get; set; }
        public string Status { get; set; }
        public int RemainingProcessingTime { get; set; }
        public string ViewHTML { get; set; }
        public List<object> Captions { get; set; }
    }

    public class CourseImage
    {
        public string Img_50X50 { get; set; }
        public string Img_75X75 { get; set; }
        public string Img_100X100 { get; set; }
        public string Img_125H { get; set; }
        public string Img_200H { get; set; }
        public string Img_480X270 { get; set; }
        public string Img_304X171 { get; set; }
        public string Img_240X135 { get; set; }
        public string Img_96X54 { get; set; }
        public string Img_48X27 { get; set; }
    }


    public class PeopleImage
    {
        public string Img_50X50 { get; set; }
        public string Img_75X75 { get; set; }
        public string Img_100X100 { get; set; }
        public string Img_125H { get; set; }
        public string Img_200H { get; set; }
    }

    public class Owner
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public PeopleImage Images { get; set; }
        public string TimeZone { get; set; }
    }

    public class VisibleInstructor
    {
        public string ID { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public PeopleImage Images { get; set; }
        public string TimeZone { get; set; }
    }

    public class Course
    {
        public string ID { get; set; }
        public PromoAsset PromoAsset { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Url { get; set; }
        public int NumLectures { get; set; }
        public int NumSubscribers { get; set; }
        public object NumInvitationRequests { get; set; }
        public string ContentInfo { get; set; }
        public string OriginalPriceText { get; set; }
        public int NumOfReviews { get; set; }
        public int NumOfTextReviews { get; set; }
        public double AvgRating { get; set; }
        public double AvgRatingRounded { get; set; }
        public string Price { get; set; }
        public Owner Owner { get; set; }
        public CourseImage Images { get; set; }
        public string PublishedTime { get; set; }
        public object IsInstructor { get; set; }
        public bool CanEdit { get; set; }
        public string IsPremium { get; set; }
        public bool IsPaid { get; set; }
        public string IsPublished { get; set; }
        public string GiftUrl { get; set; }
        public bool IsPrivate { get; set; }
        public bool IsInAppPurchaseEnabled { get; set; }
        public bool IsGoogleInAppPurchaseEnabled { get; set; }
        public bool FavoriteTime { get; set; }
        public bool ArchiveTime { get; set; }
        public string GoogleInAppPurchasePriceText { get; set; }
        public string InAppPurchasePriceText { get; set; }
        public List<VisibleInstructor> VisibleInstructors { get; set; }
        public bool IsAvaliableOnIos { get; set; }
        public bool HasCertificate { get; set; }
        public string Locale { get; set; }
        public string InstructionalLevel { get; set; }
    }

    public class CourseContent
    {
        public string ID { get; set; }
        public string CourseId { get; set; }
        public string Type { get; set; }
        public string TypeText { get; set; }
        public int SortOrder { get; set; }
        public int ChapterIndex { get; set; }
        public int ObjectIndex { get; set; }
        public string IsPublished { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public bool IsLocked { get; set; }
        public string Description { get; set; }
        public string AssetType { get; set; }
        public int? LectureIndex { get; set; }
        public string ContextInfo { get; set; }
        public string IsFree { get; set; }
        public Asset Asset { get; set; }
        public Images Images { get; set; }
        public List<object> Extras { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
        public string PublicUrl { get; set; }
        public string CompletionRatio { get; set; }
        public string ProgressStatus { get; set; }
        public string IsDownloadable { get; set; }
        public int? StartPosition { get; set; }
        public TimeEstimate TimeEstimate { get; set; }
        public bool? NoteExists { get; set; }
        public bool? SourceCodeExists { get; set; }
        public bool? ExternalLinkExists { get; set; }
        public string IconClass { get; set; }
        public string HasImage { get; set; }
        public string HasImageOnS3 { get; set; }
        public bool? HasCaption { get; set; }
    }

    public class CourseCurriculum
    {
        public Dictionary<int, string> Chapters { get; set; }
        public List<CourseContent> Lectures { get; set; }
        public List<Asset> DownloadableResources { get; set; }
    }
}