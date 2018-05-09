namespace Repository.Entities
{
    public class RealTimeChoices
    {
        public string Top5SearchCategoriesFirstCategoryName { get; set; }
        public int Top5SearchCategoriesFirstCategoryCount { get; set; }
        public string Top5SearchCategoriesSecondCategoryName { get; set; }
        public int Top5SearchCategoriesSecondCategoryCount { get; set; }
        public string Top5SearchCategoriesThirdCategoryName { get; set; }
        public int Top5SearchCategoriesThirdCategoryCount { get; set; }
        public string Top5SearchCategoriesFourthCategoryName { get; set; }
        public int Top5SearchCategoriesFourthCategoryCount { get; set; }
        public string Top5SearchCategoriesFifthCategoryName { get; set; }
        public int Top5SearchCategoriesFifthCategoryCount { get; set; }
        public int Top5SearchCategoriesTotalCount { get; set; }
        public int? VisitsWebsiteCount { get; set; }
        public int? VisitsWebsitePercent { get; set; }
        public int? VisitsMobileCount { get; set; }
        public int? VisitsMobilePercent { get; set; }
        public int? VisitsTotalCount { get; set; }
        public int? VisitsTotalPercent { get; set; }
        public int? UtilizationPercent { get; set; }
    }
}
