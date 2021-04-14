using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace autoliading_xml_interaction
{
    partial class YandexXmlParser
    {
        /// <summary>
        /// Парсинг переданного в конструктор xmlFileContent: извлечение значений для свойств объекта Ad
        /// </summary>
        public LinkedList<Ad> GetAds()
        {
            Regex regex = new Regex(
                @"<offer>\s{0,2}" +
                    @"<!-- \[CATEGORY_ID=(?<CATEGORY_ID>(ID\d+))\] -->\s{0,2}" + // Извлечение CategoryId из <!-- [CATEGORY_ID=идентификатор] -->
                    @"<!-- \[END_DATE=(?<END_DATE>(\d{4}\-\d{2}\-\d{2}))\] -->\s{0,2}" + // Извлечение EndDate из <!-- [END_DATE=дата] -->
                    @"<id>(?<AD_ID>(ID\d+))</id>" + // Извлечение Id из <id>идентификатор</id>
                    @"[\S\s]+?" + // промежуточные строки
                    @"<title>(?<AD_NAME>(.+))</title>\s{0,2}" + // Извлечение Name из <title>имя</title>
                    @"<description><!\[CDATA\[\s{0,4}" + // <description><![CDATA[
                        @"(?<DESCRIPTION>([\S\s]+?))" + // Извлечение Description из <description><![CDATA[описание]]></description>
                    @"\s{0,4}\]\]></description>\s{0,2}" + // ]]></description>
                    @"[\S\s]+?" + // промежуточные строки
                    @"<price>(?<PRICE>(\d+))</price>\s{0,2}" + // Извлечение Price из <price>цена</price>" +
                "</offer>"
            );
            LinkedList<Ad> adList = new LinkedList<Ad>();
            foreach (Match match in regex.Matches(xmlFileContent))
            {
                Ad ad = new Ad
                {
                    Id = match.Groups["AD_ID"].Value,
                    Name = match.Groups["AD_NAME"].Value,
                    Description = match.Groups["DESCRIPTION"].Value,
                    Price = Convert.ToInt32(match.Groups["PRICE"].Value),
                    CategoryId = match.Groups["CATEGORY_ID"].Value
                };
                string[] splitedEndDate = match.Groups["END_DATE"].Value.Split('-');
                ad.EndDate = new DateTime(
                    year: Convert.ToInt32(splitedEndDate[0]),
                    month: Convert.ToInt32(splitedEndDate[1]),
                    day: Convert.ToInt32(splitedEndDate[2])
                );
                adList.AddLast(ad);
            }
            return adList;
        }
    }
}
