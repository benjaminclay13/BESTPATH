using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.IO;
using System.Web.Security;
using System.Net;
using System.Data.SqlClient;
using System.Net.Security;
using System.Data;
using System.Collections;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Linq;

namespace BESTPATH
{
    public class DeliverableCreation
    {
        private string errorMessage;

        public string getErrorMessage()
        {
            return this.errorMessage;

        }//end property

        public void setErrorMessage(string ErrorMessage)
        {
            this.errorMessage = ErrorMessage;

        }//end property

        public DeliverableCreation()
        {
            this.errorMessage = null;

        }//end constructor

        public static string Create_Statement_Of_Value(ArrayList DeliverableCreationRecord, string SavePath, string TemplatePath)
        {
            DeliverableCreation deliverableCreationObject = new DeliverableCreation();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(TemplatePath);

                string _doc = doc.OuterXml;


                string fullNameTag = "FullNameFullNameFullNameFullNameFullName";
                string degreesTag = "DegreesDegreesDegreesDegreesDegrees";
                string streetAddressTag = "StreetAddressStreetAddress";
                string cityStateZipTag = "CityStateZipCityStateZip";
                string emailAddressTag = "EmailAddressEmailAddress";
                string phoneNumberTag = "PhoneNumber";
                string focusTag = "FocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocusFocus";
                string theme1Tag = "Theme1Theme1Theme1Theme1Theme1Theme1Theme1Theme1Theme1Theme1Theme1Theme1";
                string theme2Tag = "Theme2Theme2Theme2Theme2Theme2Theme2Theme2Theme2Theme2Theme2Theme2Theme2";
                string theme3Tag = "Theme3Theme3Theme3Theme3Theme3Theme3Theme3Theme3Theme3Theme3Theme3Theme3";
                string section2TitleTag = "Section2Title";
                string personalDescriptor1Tag = "PersonalDescriptor1PersonalDescriptor1PersonalDescriptor1";
                string personalDescriptor2Tag = "PersonalDescriptor2PersonalDescriptor2PersonalDescriptor2";
                string personalDescriptor3Tag = "PersonalDescriptor3PersonalDescriptor3PersonalDescriptor3";
                string qualification1Tag = "Qualification1Qualification1Qualifi";
                string qualification2Tag = "Qualification2Qualification2Qualifi";
                string qualification3Tag = "Qualification3Qualification3Qualifi";
                string qualification4Tag = "Qualification4Qualification4Qualifi";
                string qualification5Tag = "Qualification5Qualification5Qualifi";
                string qualification6Tag = "Qualification6Qualification6Qualifi";
                string qualification7Tag = "Qualification7Qualification7Qualifi";
                string qualification8Tag = "Qualification8Qualification8Qualifi";
                string qualification9Tag = "Qualification9Qualification9Qualifi";
                string section3TitleTag = "Section3TitleSection3TitleSection3TitleSection3TitleSection3Title";
                string achievement1Tag = "Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement1Achievement";
                string achievement2Tag = "Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement2Achievement";
                string achievement3Tag = "Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement3Achievement";
                string achievement4Tag = "Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement4Achievement";
                string achievement5Tag = "Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement5Achievement";
                string achievement6Tag = "Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement6Achievement";
                string achievement7Tag = "Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement7Achievement";
                string achievement8Tag = "Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement8Achievement";
                string section4TitleTag = "Section4TitleSection4TitleSection4TitleSection4TitleSection4Title";
                string jobTitlesTag = "JobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTitlesJobTi";


                string fullName = DeliverableCreationRecord[1].ToString();
                string degrees = DeliverableCreationRecord[2].ToString();
                string streetAddress = DeliverableCreationRecord[3].ToString();
                string cityStateZip = DeliverableCreationRecord[4].ToString();
                string emailAddress = DeliverableCreationRecord[5].ToString();
                string phoneNumber = DeliverableCreationRecord[6].ToString();
                string section1Title = DeliverableCreationRecord[7].ToString();
                string focus = DeliverableCreationRecord[8].ToString();
                string theme1 = DeliverableCreationRecord[9].ToString();
                string theme2 = DeliverableCreationRecord[10].ToString();
                string theme3 = DeliverableCreationRecord[11].ToString();
                string section2Title = DeliverableCreationRecord[12].ToString();
                string personalDescriptor1 = DeliverableCreationRecord[13].ToString();
                string personalDescriptor2 = DeliverableCreationRecord[14].ToString();
                string personalDescriptor3 = DeliverableCreationRecord[15].ToString();
                string qualification1 = DeliverableCreationRecord[16].ToString();
                string qualification2 = DeliverableCreationRecord[17].ToString();
                string qualification3 = DeliverableCreationRecord[18].ToString();
                string qualification4 = DeliverableCreationRecord[19].ToString();
                string qualification5 = DeliverableCreationRecord[20].ToString();
                string qualification6 = DeliverableCreationRecord[21].ToString();
                string qualification7 = DeliverableCreationRecord[22].ToString();
                string qualification8 = DeliverableCreationRecord[23].ToString();
                string qualification9 = DeliverableCreationRecord[24].ToString();
                string section3Title = DeliverableCreationRecord[25].ToString();
                string achievement1 = DeliverableCreationRecord[26].ToString();
                string achievement2 = DeliverableCreationRecord[27].ToString();
                string achievement3 = DeliverableCreationRecord[28].ToString();
                string achievement4 = DeliverableCreationRecord[29].ToString();
                string achievement5 = DeliverableCreationRecord[30].ToString();
                string achievement6 = DeliverableCreationRecord[31].ToString();
                string achievement7 = DeliverableCreationRecord[32].ToString();
                string achievement8 = DeliverableCreationRecord[33].ToString();
                string section4Title = DeliverableCreationRecord[34].ToString();
                string jobTitles = DeliverableCreationRecord[35].ToString();


                fullName = fullName.Replace("&", "&amp;");
                degrees = degrees.Replace("&", "&amp;");
                streetAddress = streetAddress.Replace("&", "&amp;");
                cityStateZip = cityStateZip.Replace("&", "&amp;");
                emailAddress = emailAddress.Replace("&", "&amp;");
                phoneNumber = phoneNumber.Replace("&", "&amp;");
                section1Title = section1Title.Replace("&", "&amp;");
                focus = focus.Replace("&", "&amp;");
                theme1 = theme1.Replace("&", "&amp;");
                theme2 = theme2.Replace("&", "&amp;");
                theme3 = theme3.Replace("&", "&amp;");
                section2Title = section2Title.Replace("&", "&amp;");
                personalDescriptor1 = personalDescriptor1.Replace("&", "&amp;");
                personalDescriptor2 = personalDescriptor2.Replace("&", "&amp;");
                personalDescriptor3 = personalDescriptor3.Replace("&", "&amp;");
                qualification1 = qualification1.Replace("&", "&amp;");
                qualification2 = qualification2.Replace("&", "&amp;");
                qualification3 = qualification3.Replace("&", "&amp;");
                qualification4 = qualification4.Replace("&", "&amp;");
                qualification5 = qualification5.Replace("&", "&amp;");
                qualification6 = qualification6.Replace("&", "&amp;");
                qualification7 = qualification7.Replace("&", "&amp;");
                qualification8 = qualification8.Replace("&", "&amp;");
                qualification9 = qualification9.Replace("&", "&amp;");
                section3Title = section3Title.Replace("&", "&amp;");
                achievement1 = achievement1.Replace("&", "&amp;");
                achievement2 = achievement2.Replace("&", "&amp;");
                achievement3 = achievement3.Replace("&", "&amp;");
                achievement4 = achievement4.Replace("&", "&amp;");
                achievement5 = achievement5.Replace("&", "&amp;");
                achievement6 = achievement6.Replace("&", "&amp;");
                achievement7 = achievement7.Replace("&", "&amp;");
                achievement8 = achievement8.Replace("&", "&amp;");
                section4Title = section4Title.Replace("&", "&amp;");
                jobTitles = jobTitles.Replace("&", "&amp;");


                fullName = fullName.Replace("<", "&lt;");
                degrees = degrees.Replace("<", "&lt;");
                streetAddress = streetAddress.Replace("<", "&lt;");
                cityStateZip = cityStateZip.Replace("<", "&lt;");
                emailAddress = emailAddress.Replace("<", "&lt;");
                phoneNumber = phoneNumber.Replace("<", "&lt;");
                section1Title = section1Title.Replace("<", "&lt;");
                focus = focus.Replace("<", "&lt;");
                theme1 = theme1.Replace("<", "&lt;");
                theme2 = theme2.Replace("<", "&lt;");
                theme3 = theme3.Replace("<", "&lt;");
                section2Title = section2Title.Replace("<", "&lt;");
                personalDescriptor1 = personalDescriptor1.Replace("<", "&lt;");
                personalDescriptor2 = personalDescriptor2.Replace("<", "&lt;");
                personalDescriptor3 = personalDescriptor3.Replace("<", "&lt;");
                qualification1 = qualification1.Replace("<", "&lt;");
                qualification2 = qualification2.Replace("<", "&lt;");
                qualification3 = qualification3.Replace("<", "&lt;");
                qualification4 = qualification4.Replace("<", "&lt;");
                qualification5 = qualification5.Replace("<", "&lt;");
                qualification6 = qualification6.Replace("<", "&lt;");
                qualification7 = qualification7.Replace("<", "&lt;");
                qualification8 = qualification8.Replace("<", "&lt;");
                qualification9 = qualification9.Replace("<", "&lt;");
                section3Title = section3Title.Replace("<", "&lt;");
                achievement1 = achievement1.Replace("<", "&lt;");
                achievement2 = achievement2.Replace("<", "&lt;");
                achievement3 = achievement3.Replace("<", "&lt;");
                achievement4 = achievement4.Replace("<", "&lt;");
                achievement5 = achievement5.Replace("<", "&lt;");
                achievement6 = achievement6.Replace("<", "&lt;");
                achievement7 = achievement7.Replace("<", "&lt;");
                achievement8 = achievement8.Replace("<", "&lt;");
                section4Title = section4Title.Replace("<", "&lt;");
                jobTitles = jobTitles.Replace("<", "&lt;");


                fullName = fullName.Replace(">", "&gt;");
                degrees = degrees.Replace(">", "&gt;");
                streetAddress = streetAddress.Replace(">", "&gt;");
                cityStateZip = cityStateZip.Replace(">", "&gt;");
                emailAddress = emailAddress.Replace(">", "&gt;");
                phoneNumber = phoneNumber.Replace(">", "&gt;");
                section1Title = section1Title.Replace(">", "&gt;");
                focus = focus.Replace(">", "&gt;");
                theme1 = theme1.Replace(">", "&gt;");
                theme2 = theme2.Replace(">", "&gt;");
                theme3 = theme3.Replace(">", "&gt;");
                section2Title = section2Title.Replace(">", "&gt;");
                personalDescriptor1 = personalDescriptor1.Replace(">", "&gt;");
                personalDescriptor2 = personalDescriptor2.Replace(">", "&gt;");
                personalDescriptor3 = personalDescriptor3.Replace(">", "&gt;");
                qualification1 = qualification1.Replace(">", "&gt;");
                qualification2 = qualification2.Replace(">", "&gt;");
                qualification3 = qualification3.Replace(">", "&gt;");
                qualification4 = qualification4.Replace(">", "&gt;");
                qualification5 = qualification5.Replace(">", "&gt;");
                qualification6 = qualification6.Replace(">", "&gt;");
                qualification7 = qualification7.Replace(">", "&gt;");
                qualification8 = qualification8.Replace(">", "&gt;");
                qualification9 = qualification9.Replace(">", "&gt;");
                section3Title = section3Title.Replace(">", "&gt;");
                achievement1 = achievement1.Replace(">", "&gt;");
                achievement2 = achievement2.Replace(">", "&gt;");
                achievement3 = achievement3.Replace(">", "&gt;");
                achievement4 = achievement4.Replace(">", "&gt;");
                achievement5 = achievement5.Replace(">", "&gt;");
                achievement6 = achievement6.Replace(">", "&gt;");
                achievement7 = achievement7.Replace(">", "&gt;");
                achievement8 = achievement8.Replace(">", "&gt;");
                section4Title = section4Title.Replace(">", "&gt;");
                jobTitles = jobTitles.Replace(">", "&gt;");


                fullName = fullName.Replace("\"", "&quot;");
                degrees = degrees.Replace("\"", "&quot;");
                streetAddress = streetAddress.Replace("\"", "&quot;");
                cityStateZip = cityStateZip.Replace("\"", "&quot;");
                emailAddress = emailAddress.Replace("\"", "&quot;");
                phoneNumber = phoneNumber.Replace("\"", "&quot;");
                section1Title = section1Title.Replace("\"", "&quot;");
                focus = focus.Replace("\"", "&quot;");
                theme1 = theme1.Replace("\"", "&quot;");
                theme2 = theme2.Replace("\"", "&quot;");
                theme3 = theme3.Replace("\"", "&quot;");
                section2Title = section2Title.Replace("\"", "&quot;");
                personalDescriptor1 = personalDescriptor1.Replace("\"", "&quot;");
                personalDescriptor2 = personalDescriptor2.Replace("\"", "&quot;");
                personalDescriptor3 = personalDescriptor3.Replace("\"", "&quot;");
                qualification1 = qualification1.Replace("\"", "&quot;");
                qualification2 = qualification2.Replace("\"", "&quot;");
                qualification3 = qualification3.Replace("\"", "&quot;");
                qualification4 = qualification4.Replace("\"", "&quot;");
                qualification5 = qualification5.Replace("\"", "&quot;");
                qualification6 = qualification6.Replace("\"", "&quot;");
                qualification7 = qualification7.Replace("\"", "&quot;");
                qualification8 = qualification8.Replace("\"", "&quot;");
                qualification9 = qualification9.Replace("\"", "&quot;");
                section3Title = section3Title.Replace("\"", "&quot;");
                achievement1 = achievement1.Replace("\"", "&quot;");
                achievement2 = achievement2.Replace("\"", "&quot;");
                achievement3 = achievement3.Replace("\"", "&quot;");
                achievement4 = achievement4.Replace("\"", "&quot;");
                achievement5 = achievement5.Replace("\"", "&quot;");
                achievement6 = achievement6.Replace("\"", "&quot;");
                achievement7 = achievement7.Replace("\"", "&quot;");
                achievement8 = achievement8.Replace("\"", "&quot;");
                section4Title = section4Title.Replace("\"", "&quot;");
                jobTitles = jobTitles.Replace("\"", "&quot;");


                fullName = fullName.Replace("'", "&apos;");
                degrees = degrees.Replace("'", "&apos;");
                streetAddress = streetAddress.Replace("'", "&apos;");
                cityStateZip = cityStateZip.Replace("'", "&apos;");
                emailAddress = emailAddress.Replace("'", "&apos;");
                phoneNumber = phoneNumber.Replace("'", "&apos;");
                section1Title = section1Title.Replace("'", "&apos;");
                focus = focus.Replace("'", "&apos;");
                theme1 = theme1.Replace("'", "&apos;");
                theme2 = theme2.Replace("'", "&apos;");
                theme3 = theme3.Replace("'", "&apos;");
                section2Title = section2Title.Replace("'", "&apos;");
                personalDescriptor1 = personalDescriptor1.Replace("'", "&apos;");
                personalDescriptor2 = personalDescriptor2.Replace("'", "&apos;");
                personalDescriptor3 = personalDescriptor3.Replace("'", "&apos;");
                qualification1 = qualification1.Replace("'", "&apos;");
                qualification2 = qualification2.Replace("'", "&apos;");
                qualification3 = qualification3.Replace("'", "&apos;");
                qualification4 = qualification4.Replace("'", "&apos;");
                qualification5 = qualification5.Replace("'", "&apos;");
                qualification6 = qualification6.Replace("'", "&apos;");
                qualification7 = qualification7.Replace("'", "&apos;");
                qualification8 = qualification8.Replace("'", "&apos;");
                qualification9 = qualification9.Replace("'", "&apos;");
                section3Title = section3Title.Replace("'", "&apos;");
                achievement1 = achievement1.Replace("'", "&apos;");
                achievement2 = achievement2.Replace("'", "&apos;");
                achievement3 = achievement3.Replace("'", "&apos;");
                achievement4 = achievement4.Replace("'", "&apos;");
                achievement5 = achievement5.Replace("'", "&apos;");
                achievement6 = achievement6.Replace("'", "&apos;");
                achievement7 = achievement7.Replace("'", "&apos;");
                achievement8 = achievement8.Replace("'", "&apos;");
                section4Title = section4Title.Replace("'", "&apos;");
                jobTitles = jobTitles.Replace("'", "&apos;");


                _doc = _doc.Replace(fullNameTag, fullName);
                _doc = _doc.Replace(degreesTag, degrees);
                _doc = _doc.Replace(streetAddressTag, streetAddress);
                _doc = _doc.Replace(cityStateZipTag, cityStateZip);
                _doc = _doc.Replace(emailAddressTag, emailAddress);
                _doc = _doc.Replace(phoneNumberTag, phoneNumber);
                _doc = _doc.Replace(focusTag, focus);
                _doc = _doc.Replace(theme1Tag, theme1);
                _doc = _doc.Replace(theme2Tag, theme2);
                _doc = _doc.Replace(theme3Tag, theme3);
                _doc = _doc.Replace(section2TitleTag, section2Title);
                _doc = _doc.Replace(personalDescriptor1Tag, personalDescriptor1);
                _doc = _doc.Replace(personalDescriptor2Tag, personalDescriptor2);
                _doc = _doc.Replace(personalDescriptor3Tag, personalDescriptor3);
                _doc = _doc.Replace(qualification1Tag, qualification1);
                _doc = _doc.Replace(qualification2Tag, qualification2);
                _doc = _doc.Replace(qualification3Tag, qualification3);
                _doc = _doc.Replace(qualification4Tag, qualification4);
                _doc = _doc.Replace(qualification5Tag, qualification5);
                _doc = _doc.Replace(qualification6Tag, qualification6);
                _doc = _doc.Replace(qualification7Tag, qualification7);
                _doc = _doc.Replace(qualification8Tag, qualification8);
                _doc = _doc.Replace(qualification9Tag, qualification9);
                _doc = _doc.Replace(section3TitleTag, section3Title);
                _doc = _doc.Replace(achievement1Tag, achievement1);
                _doc = _doc.Replace(achievement2Tag, achievement2);
                _doc = _doc.Replace(achievement3Tag, achievement3);
                _doc = _doc.Replace(achievement4Tag, achievement4);
                _doc = _doc.Replace(achievement5Tag, achievement5);
                _doc = _doc.Replace(achievement6Tag, achievement6);
                _doc = _doc.Replace(achievement7Tag, achievement7);
                _doc = _doc.Replace(achievement8Tag, achievement8);
                _doc = _doc.Replace(section4TitleTag, section4Title);
                _doc = _doc.Replace(jobTitlesTag, jobTitles);


                File.WriteAllText(SavePath, _doc);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Marketing Documents Creation Error: " + ex.Message.ToString();

                deliverableCreationObject.setErrorMessage(errorMessage);

            }//end catch

            return deliverableCreationObject.getErrorMessage();

        }//end method


        public static string Create_Expanded_Experience_Profile(ArrayList DeliverableCreationRecord, string SavePath, string TemplatePath)
        {
            DeliverableCreation deliverableCreationObject = new DeliverableCreation();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(TemplatePath);

                string _doc = doc.OuterXml;


                string fullNameTag = "FullNameFullNameFullNameFullNameFullName";
                string degreesTag = "DegreesDegreesDegreesDegreesDegrees";
                string streetAddressTag = "StreetAddressStreetAddress";
                string cityStateZipTag = "CityStateZipCityStateZip";
                string emailAddressTag = "EmailAddressEmailAddress";
                string phoneNumberTag = "PhoneNumber";
                string jobTitle1Tag = "JobTitle1JobTitle1JobTitle1JobTitle1";
                string companyName1Tag = "CompanyName1CompanyName1";
                string years1Tag = "Years1Years1";
                string narrative1Tag = "Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1Narrative1";
                string jobTitle2Tag = "JobTitle2JobTitle2JobTitle2JobTitle2";
                string companyName2Tag = "CompanyName2CompanyName2";
                string years2Tag = "Years2Years2";
                string narrative2Tag = "Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2Narrative2";
                string jobTitle3Tag = "JobTitle3JobTitle3JobTitle3JobTitle3";
                string companyName3Tag = "CompanyName3CompanyName3";
                string years3Tag = "Years3Years3";
                string narrative3Tag = "Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3Narrative3";
                string jobTitle4Tag = "JobTitle4JobTitle4JobTitle4JobTitle4";
                string companyName4Tag = "CompanyName4CompanyName4";
                string years4Tag = "Years4Years4";
                string narrative4Tag = "Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4Narrative4";
                string jobTitle5Tag = "JobTitle5JobTitle5JobTitle5JobTitle5";
                string companyName5Tag = "CompanyName5CompanyName5";
                string years5Tag = "Years5Years5";
                string narrative5Tag = "Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5Narrative5";
                string educationTitleTag = "EducationTitle";
                string educationTag = "EducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducationEducation";
                string trainingTitleTag = "TrainingTitle";
                string trainingTag = "TrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTrainingTraining";
                string honorsAndAwardsTitleTag = "HonorsAndAwardsTitle";
                string honorsAndAwardsTag = "HonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwardsHonorsAndAwards";
                string militaryServiceTitleTag = "MilitaryServiceTitle";
                string militaryServiceTag = "MilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryService MilitaryServiceMilitaryServiceMilitaryServiceMilitaryServiceMilitaryService";
                string voluntaryPositionsTitleTag = "VoluntaryPositionsTitle";
                string voluntaryPositionsTag = "VoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositionsVoluntaryPositions";
                string otherTitleTag = "OtherTitle";
                string otherTag = "OtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOtherOther";
                

                string fullName = DeliverableCreationRecord[1].ToString();
                string degrees = DeliverableCreationRecord[2].ToString();
                string streetAddress = DeliverableCreationRecord[3].ToString();
                string cityStateZip = DeliverableCreationRecord[4].ToString();
                string emailAddress = DeliverableCreationRecord[5].ToString();
                string phoneNumber = DeliverableCreationRecord[6].ToString();
                string jobTitle1 = DeliverableCreationRecord[36].ToString();
                string companyName1 = DeliverableCreationRecord[37].ToString();
                string years1 = DeliverableCreationRecord[38].ToString();
                string narrative1 = DeliverableCreationRecord[39].ToString();
                string jobTitle2 = DeliverableCreationRecord[40].ToString();
                string companyName2 = DeliverableCreationRecord[41].ToString();
                string years2 = DeliverableCreationRecord[42].ToString();
                string narrative2 = DeliverableCreationRecord[43].ToString();
                string jobTitle3 = DeliverableCreationRecord[44].ToString();
                string companyName3 = DeliverableCreationRecord[45].ToString();
                string years3 = DeliverableCreationRecord[46].ToString();
                string narrative3 = DeliverableCreationRecord[47].ToString();
                string jobTitle4 = DeliverableCreationRecord[48].ToString();
                string companyName4 = DeliverableCreationRecord[49].ToString();
                string years4 = DeliverableCreationRecord[50].ToString();
                string narrative4 = DeliverableCreationRecord[51].ToString();
                string jobTitle5 = DeliverableCreationRecord[52].ToString();
                string companyName5 = DeliverableCreationRecord[53].ToString();
                string years5 = DeliverableCreationRecord[54].ToString();
                string narrative5 = DeliverableCreationRecord[55].ToString();
                string educationTitle = DeliverableCreationRecord[56].ToString();
                string education = DeliverableCreationRecord[57].ToString();
                string trainingTitle = DeliverableCreationRecord[58].ToString();
                string training = DeliverableCreationRecord[59].ToString();
                string honorsAndAwardsTitle = DeliverableCreationRecord[60].ToString();
                string honorsAndAwards = DeliverableCreationRecord[61].ToString();
                string militaryServiceTitle = DeliverableCreationRecord[62].ToString();
                string militaryService = DeliverableCreationRecord[63].ToString();
                string voluntaryPositionsTitle = DeliverableCreationRecord[64].ToString();
                string voluntaryPositions = DeliverableCreationRecord[65].ToString();
                string otherTitle = DeliverableCreationRecord[66].ToString();
                string other = DeliverableCreationRecord[67].ToString();


                fullName = fullName.Replace("&", "&amp;");
                degrees = degrees.Replace("&", "&amp;");
                streetAddress = streetAddress.Replace("&", "&amp;");
                cityStateZip = cityStateZip.Replace("&", "&amp;");
                emailAddress = emailAddress.Replace("&", "&amp;");
                phoneNumber = phoneNumber.Replace("&", "&amp;");
                jobTitle1 = jobTitle1.Replace("&", "&amp;");
                companyName1 = companyName1.Replace("&", "&amp;");
                years1 = years1.Replace("&", "&amp;");
                narrative1 = narrative1.Replace("&", "&amp;");
                jobTitle2 = jobTitle2.Replace("&", "&amp;");
                companyName2 = companyName2.Replace("&", "&amp;");
                years2 = years2.Replace("&", "&amp;");
                narrative2 = narrative2.Replace("&", "&amp;");
                jobTitle3 = jobTitle3.Replace("&", "&amp;");
                companyName3 = companyName3.Replace("&", "&amp;");
                years3 = years3.Replace("&", "&amp;");
                narrative3 = narrative3.Replace("&", "&amp;");
                jobTitle4 = jobTitle4.Replace("&", "&amp;");
                companyName4 = companyName4.Replace("&", "&amp;");
                years4 = years4.Replace("&", "&amp;");
                narrative4 = narrative4.Replace("&", "&amp;");
                jobTitle5 = jobTitle5.Replace("&", "&amp;");
                companyName5 = companyName5.Replace("&", "&amp;");
                years5 = years5.Replace("&", "&amp;");
                narrative5 = narrative5.Replace("&", "&amp;");
                education = education.Replace("&", "&amp;");
                training = training.Replace("&", "&amp;");
                honorsAndAwards = honorsAndAwards.Replace("&", "&amp;");
                militaryService = militaryService.Replace("&", "&amp;");
                voluntaryPositions = voluntaryPositions.Replace("&", "&amp;");
                other = other.Replace("&", "&amp;");


                fullName = fullName.Replace("<", "&lt;");
                degrees = degrees.Replace("<", "&lt;");
                streetAddress = streetAddress.Replace("<", "&lt;");
                cityStateZip = cityStateZip.Replace("<", "&lt;");
                emailAddress = emailAddress.Replace("<", "&lt;");
                phoneNumber = phoneNumber.Replace("<", "&lt;");
                jobTitle1 = jobTitle1.Replace("<", "&lt;");
                companyName1 = companyName1.Replace("<", "&lt;");
                years1 = years1.Replace("<", "&lt;");
                narrative1 = narrative1.Replace("<", "&lt;");
                jobTitle2 = jobTitle2.Replace("<", "&lt;");
                companyName2 = companyName2.Replace("<", "&lt;");
                years2 = years2.Replace("<", "&lt;");
                narrative2 = narrative2.Replace("<", "&lt;");
                jobTitle3 = jobTitle3.Replace("<", "&lt;");
                companyName3 = companyName3.Replace("<", "&lt;");
                years3 = years3.Replace("<", "&lt;");
                narrative3 = narrative3.Replace("<", "&lt;");
                jobTitle4 = jobTitle4.Replace("<", "&lt;");
                companyName4 = companyName4.Replace("<", "&lt;");
                years4 = years4.Replace("<", "&lt;");
                narrative4 = narrative4.Replace("<", "&lt;");
                jobTitle5 = jobTitle5.Replace("<", "&lt;");
                companyName5 = companyName5.Replace("<", "&lt;");
                years5 = years5.Replace("<", "&lt;");
                narrative5 = narrative5.Replace("<", "&lt;");
                education = education.Replace("<", "&lt;");
                training = training.Replace("<", "&lt;");
                honorsAndAwards = honorsAndAwards.Replace("<", "&lt;");
                militaryService = militaryService.Replace("<", "&lt;");
                voluntaryPositions = voluntaryPositions.Replace("<", "&lt;");
                other = other.Replace("<", "&lt;");


                fullName = fullName.Replace(">", "&gt;");
                degrees = degrees.Replace(">", "&gt;");
                streetAddress = streetAddress.Replace(">", "&gt;");
                cityStateZip = cityStateZip.Replace(">", "&gt;");
                emailAddress = emailAddress.Replace(">", "&gt;");
                phoneNumber = phoneNumber.Replace(">", "&gt;");
                jobTitle1 = jobTitle1.Replace(">", "&gt;");
                companyName1 = companyName1.Replace(">", "&gt;");
                years1 = years1.Replace(">", "&gt;");
                narrative1 = narrative1.Replace(">", "&gt;");
                jobTitle2 = jobTitle2.Replace(">", "&gt;");
                companyName2 = companyName2.Replace(">", "&gt;");
                years2 = years2.Replace(">", "&gt;");
                narrative2 = narrative2.Replace(">", "&gt;");
                jobTitle3 = jobTitle3.Replace(">", "&gt;");
                companyName3 = companyName3.Replace(">", "&gt;");
                years3 = years3.Replace(">", "&gt;");
                narrative3 = narrative3.Replace(">", "&gt;");
                jobTitle4 = jobTitle4.Replace(">", "&gt;");
                companyName4 = companyName4.Replace(">", "&gt;");
                years4 = years4.Replace(">", "&gt;");
                narrative4 = narrative4.Replace(">", "&gt;");
                jobTitle5 = jobTitle5.Replace(">", "&gt;");
                companyName5 = companyName5.Replace(">", "&gt;");
                years5 = years5.Replace(">", "&gt;");
                narrative5 = narrative5.Replace(">", "&gt;");
                education = education.Replace(">", "&gt;");
                training = training.Replace(">", "&gt;");
                honorsAndAwards = honorsAndAwards.Replace(">", "&gt;");
                militaryService = militaryService.Replace(">", "&gt;");
                voluntaryPositions = voluntaryPositions.Replace(">", "&gt;");
                other = other.Replace(">", "&gt;");


                fullName = fullName.Replace("\"", "&quot;");
                degrees = degrees.Replace("\"", "&quot;");
                streetAddress = streetAddress.Replace("\"", "&quot;");
                cityStateZip = cityStateZip.Replace("\"", "&quot;");
                emailAddress = emailAddress.Replace("\"", "&quot;");
                phoneNumber = phoneNumber.Replace("\"", "&quot;");
                jobTitle1 = jobTitle1.Replace("\"", "&quot;");
                companyName1 = companyName1.Replace("\"", "&quot;");
                years1 = years1.Replace("\"", "&quot;");
                narrative1 = narrative1.Replace("\"", "&quot;");
                jobTitle2 = jobTitle2.Replace("\"", "&quot;");
                companyName2 = companyName2.Replace("\"", "&quot;");
                years2 = years2.Replace("\"", "&quot;");
                narrative2 = narrative2.Replace("\"", "&quot;");
                jobTitle3 = jobTitle3.Replace("\"", "&quot;");
                companyName3 = companyName3.Replace("\"", "&quot;");
                years3 = years3.Replace("\"", "&quot;");
                narrative3 = narrative3.Replace("\"", "&quot;");
                jobTitle4 = jobTitle4.Replace("\"", "&quot;");
                companyName4 = companyName4.Replace("\"", "&quot;");
                years4 = years4.Replace("\"", "&quot;");
                narrative4 = narrative4.Replace("\"", "&quot;");
                jobTitle5 = jobTitle5.Replace("\"", "&quot;");
                companyName5 = companyName5.Replace("\"", "&quot;");
                years5 = years5.Replace("\"", "&quot;");
                narrative5 = narrative5.Replace("\"", "&quot;");
                education = education.Replace("\"", "&quot;");
                training = training.Replace("\"", "&quot;");
                honorsAndAwards = honorsAndAwards.Replace("\"", "&quot;");
                militaryService = militaryService.Replace("\"", "&quot;");
                voluntaryPositions = voluntaryPositions.Replace("\"", "&quot;");
                other = other.Replace("\"", "&quot;");


                fullName = fullName.Replace("'", "&apos;");
                degrees = degrees.Replace("'", "&apos;");
                streetAddress = streetAddress.Replace("'", "&apos;");
                cityStateZip = cityStateZip.Replace("'", "&apos;");
                emailAddress = emailAddress.Replace("'", "&apos;");
                phoneNumber = phoneNumber.Replace("'", "&apos;");
                jobTitle1 = jobTitle1.Replace("'", "&apos;");
                companyName1 = companyName1.Replace("'", "&apos;");
                years1 = years1.Replace("'", "&apos;");
                narrative1 = narrative1.Replace("'", "&apos;");
                jobTitle2 = jobTitle2.Replace("'", "&apos;");
                companyName2 = companyName2.Replace("'", "&apos;");
                years2 = years2.Replace("'", "&apos;");
                narrative2 = narrative2.Replace("'", "&apos;");
                jobTitle3 = jobTitle3.Replace("'", "&apos;");
                companyName3 = companyName3.Replace("'", "&apos;");
                years3 = years3.Replace("'", "&apos;");
                narrative3 = narrative3.Replace("'", "&apos;");
                jobTitle4 = jobTitle4.Replace("'", "&apos;");
                companyName4 = companyName4.Replace("'", "&apos;");
                years4 = years4.Replace("'", "&apos;");
                narrative4 = narrative4.Replace("'", "&apos;");
                jobTitle5 = jobTitle5.Replace("'", "&apos;");
                companyName5 = companyName5.Replace("'", "&apos;");
                years5 = years5.Replace("'", "&apos;");
                narrative5 = narrative5.Replace("'", "&apos;");
                education = education.Replace("'", "&apos;");
                training = training.Replace("'", "&apos;");
                honorsAndAwards = honorsAndAwards.Replace("'", "&apos;");
                militaryService = militaryService.Replace("'", "&apos;");
                voluntaryPositions = voluntaryPositions.Replace("'", "&apos;");
                other = other.Replace("'", "&apos;");


                _doc = _doc.Replace(fullNameTag, fullName);
                _doc = _doc.Replace(degreesTag, degrees);
                _doc = _doc.Replace(streetAddressTag, streetAddress);
                _doc = _doc.Replace(cityStateZipTag, cityStateZip);
                _doc = _doc.Replace(emailAddressTag, emailAddress);
                _doc = _doc.Replace(phoneNumberTag, phoneNumber);
                _doc = _doc.Replace(jobTitle1Tag, jobTitle1);
                _doc = _doc.Replace(companyName1Tag, companyName1);
                _doc = _doc.Replace(years1Tag, years1);
                _doc = _doc.Replace(narrative1Tag, narrative1);

                string nothing = "";

                if ((jobTitle2 != nothing) && (companyName2 != nothing) && (years2 != nothing) && (narrative2 != nothing))
                {
                    _doc = _doc.Replace(jobTitle2Tag, jobTitle2);
                    _doc = _doc.Replace(companyName2Tag, companyName2);
                    _doc = _doc.Replace(years2Tag, years2);
                    _doc = _doc.Replace(narrative2Tag, narrative2);

                }//end if

                else
                {
                    _doc = _doc.Replace(jobTitle2Tag, nothing);
                    _doc = _doc.Replace(companyName2Tag, nothing);
                    _doc = _doc.Replace(years2Tag, nothing);
                    _doc = _doc.Replace(narrative2Tag, nothing);

                }//end else

                if ((jobTitle3 != nothing) && (companyName3 != nothing) && (years3 != nothing) && (narrative3 != nothing))
                {
                    _doc = _doc.Replace(jobTitle3Tag, jobTitle3);
                    _doc = _doc.Replace(companyName3Tag, companyName3);
                    _doc = _doc.Replace(years3Tag, years3);
                    _doc = _doc.Replace(narrative3Tag, narrative3);

                }//end if

                else
                {
                    _doc = _doc.Replace(jobTitle3Tag, nothing);
                    _doc = _doc.Replace(companyName3Tag, nothing);
                    _doc = _doc.Replace(years3Tag, nothing);
                    _doc = _doc.Replace(narrative3Tag, nothing);

                }//end else

                if ((jobTitle4 != nothing) && (companyName4 != nothing) && (years4 != nothing) && (narrative4 != nothing))
                {
                    _doc = _doc.Replace(jobTitle4Tag, jobTitle4);
                    _doc = _doc.Replace(companyName4Tag, companyName4);
                    _doc = _doc.Replace(years4Tag, years4);
                    _doc = _doc.Replace(narrative4Tag, narrative4);

                }//end if

                else
                {
                    _doc = _doc.Replace(jobTitle4Tag, nothing);
                    _doc = _doc.Replace(companyName4Tag, nothing);
                    _doc = _doc.Replace(years4Tag, nothing);
                    _doc = _doc.Replace(narrative4Tag, nothing);

                }//end else

                if ((jobTitle5 != nothing) && (companyName5 != nothing) && (years5 != nothing) && (narrative5 != nothing))
                {
                    _doc = _doc.Replace(jobTitle5Tag, jobTitle5);
                    _doc = _doc.Replace(companyName5Tag, companyName5);
                    _doc = _doc.Replace(years5Tag, years5);
                    _doc = _doc.Replace(narrative5Tag, narrative5);

                }//end if

                else
                {
                    _doc = _doc.Replace(jobTitle5Tag, nothing);
                    _doc = _doc.Replace(companyName5Tag, nothing);
                    _doc = _doc.Replace(years5Tag, nothing);
                    _doc = _doc.Replace(narrative5Tag, nothing);

                }//end else

                if (education != nothing)
                {
                    _doc = _doc.Replace(educationTitleTag, educationTitle);
                    _doc = _doc.Replace(educationTag, education);

                }//end if

                else
                {
                    _doc = _doc.Replace(educationTitleTag, nothing);
                    _doc = _doc.Replace(educationTag, nothing);

                }//end else

                if (training != nothing)
                {
                    _doc = _doc.Replace(trainingTitleTag, trainingTitle);
                    _doc = _doc.Replace(trainingTag, training);

                }//end if

                else
                {
                    _doc = _doc.Replace(trainingTitleTag, nothing);
                    _doc = _doc.Replace(trainingTag, nothing);

                }//end else

                if (honorsAndAwards != nothing)
                {
                    _doc = _doc.Replace(honorsAndAwardsTitleTag, honorsAndAwardsTitle);
                    _doc = _doc.Replace(honorsAndAwardsTag, honorsAndAwards);

                }//end if

                else
                {
                    _doc = _doc.Replace(honorsAndAwardsTitleTag, nothing);
                    _doc = _doc.Replace(honorsAndAwardsTag, nothing);

                }//end else

                if (militaryService != nothing)
                {
                    _doc = _doc.Replace(militaryServiceTitleTag, militaryServiceTitle);
                    _doc = _doc.Replace(militaryServiceTag, militaryService);

                }//end if

                else
                {
                    _doc = _doc.Replace(militaryServiceTitleTag, nothing);
                    _doc = _doc.Replace(militaryServiceTag, nothing);

                }//end else

                if (voluntaryPositions != nothing)
                {
                    _doc = _doc.Replace(voluntaryPositionsTitleTag, voluntaryPositionsTitle);
                    _doc = _doc.Replace(voluntaryPositionsTag, voluntaryPositions);

                }//end if

                else
                {
                    _doc = _doc.Replace(voluntaryPositionsTitleTag, nothing);
                    _doc = _doc.Replace(voluntaryPositionsTag, nothing);

                }//end else

                if (other != nothing)
                {
                    _doc = _doc.Replace(otherTitleTag, otherTitle);
                    _doc = _doc.Replace(otherTag, other);

                }//end if

                else
                {
                    _doc = _doc.Replace(otherTitleTag, nothing);
                    _doc = _doc.Replace(otherTag, nothing);

                }//end else
                

                File.WriteAllText(SavePath, _doc);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Marketing Documents Creation Error: " + ex.Message.ToString();

                deliverableCreationObject.setErrorMessage(errorMessage);

            }//end catch

            return deliverableCreationObject.getErrorMessage();

        }//end method


        public static string Create_References(ArrayList DeliverableCreationRecord, string SavePath, string TemplatePath)
        {
            DeliverableCreation deliverableCreationObject = new DeliverableCreation();

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(TemplatePath);

                string _doc = doc.OuterXml;


                string fullNameTag = "FullNameFullNameFullNameFullNameFullName";
                string degreesTag = "DegreesDegreesDegreesDegreesDegrees";
                string streetAddressTag = "StreetAddressStreetAddress";
                string cityStateZipTag = "CityStateZipCityStateZip";
                string emailAddressTag = "EmailAddressEmailAddress";
                string phoneNumberTag = "PhoneNumber";
                string name1Tag = "Name1Name1Name1Name1Name1Name1Name1";
                string title1Tag = "Title1Title1Title1Title1Title1Title1Title1Title1";
                string company1Tag = "Company1Company1Company1Company1";
                string relationship1Tag = "Relationship1Relationship1Relationship1";
                string email1Tag = "Email1Email1Email1Email1Email1Email1Email1";
                string phone1Tag = "Phone1Phone1";
                string name2Tag = "Name2Name2Name2Name2Name2Name2Name2";
                string title2Tag = "Title2Title2Title2Title2Title2Title2Title2Title2";
                string company2Tag = "Company2Company2Company2Company2";
                string relationship2Tag = "Relationship2Relationship2Relationship2";
                string email2Tag = "Email2Email2Email2Email2Email2Email2Email2";
                string phone2Tag = "Phone2Phone2";
                string name3Tag = "Name3Name3Name3Name3Name3Name3Name3";
                string title3Tag = "Title3Title3Title3Title3Title3Title3Title3Title3";
                string company3Tag = "Company3Company3Company3Company3";
                string relationship3Tag = "Relationship3Relationship3Relationship3";
                string email3Tag = "Email3Email3Email3Email3Email3Email3Email3";
                string phone3Tag = "Phone3Phone3";
                string name4Tag = "Name4Name4Name4Name4Name4Name4Name4";
                string title4Tag = "Title4Title4Title4Title4Title4Title4Title4Title4";
                string company4Tag = "Company4Company4Company4Company4";
                string relationship4Tag = "Relationship4Relationship4Relationship4";
                string email4Tag = "Email4Email4Email4Email4Email4Email4Email4";
                string phone4Tag = "Phone4Phone4";
                string name5Tag = "Name5Name5Name5Name5Name5Name5Name5";
                string title5Tag = "Title5Title5Title5Title5Title5Title5Title5Title5";
                string company5Tag = "Company5Company5Company5Company5";
                string relationship5Tag = "Relationship5Relationship5Relationship5";
                string email5Tag = "Email5Email5Email5Email5Email5Email5Email5";
                string phone5Tag = "Phone5Phone5";
                string name6Tag = "Name6Name6Name6Name6Name6Name6Name6";
                string title6Tag = "Title6Title6Title6Title6Title6Title6Title6Title6";
                string company6Tag = "Company6Company6Company6Company6";
                string relationship6Tag = "Relationship6Relationship6Relationship6";
                string email6Tag = "Email6Email6Email6Email6Email6Email6";
                string phone6Tag = "Phone6Phone6";
                string name7Tag = "Name7Name7Name7Name7Name7Name7Name7";
                string title7Tag = "Title7Title7Title7Title7Title7Title7Title7Title7";
                string company7Tag = "Company7Company7Company7Company7";
                string relationship7Tag = "Relationship7Relationship7Relationship7";
                string email7Tag = "Email7Email7Email7Email7Email7Email7Email7";
                string phone7Tag = "Phone7Phone7";
                string name8Tag = "Name8Name8Name8Name8Name8Name8Name8";
                string title8Tag = "Title8Title8Title8Title8Title8Title8Title8Title8";
                string company8Tag = "Company8Company8Company8Company8";
                string relationship8Tag = "Relationship8Relationship8Relationship8";
                string email8Tag = "Email8Email8Email8Email8Email8Email8Email8";
                string phone8Tag = "Phone8Phone8";
                

                string fullName = DeliverableCreationRecord[1].ToString();
                string degrees = DeliverableCreationRecord[2].ToString();
                string streetAddress = DeliverableCreationRecord[3].ToString();
                string cityStateZip = DeliverableCreationRecord[4].ToString();
                string emailAddress = DeliverableCreationRecord[5].ToString();
                string phoneNumber = DeliverableCreationRecord[6].ToString();
                string name1 = DeliverableCreationRecord[68].ToString();
                string title1 = DeliverableCreationRecord[69].ToString();
                string company1 = DeliverableCreationRecord[70].ToString();
                string relationship1 = DeliverableCreationRecord[71].ToString();
                string email1 = DeliverableCreationRecord[72].ToString();
                string phone1 = DeliverableCreationRecord[73].ToString();
                string name2 = DeliverableCreationRecord[74].ToString();
                string title2 = DeliverableCreationRecord[75].ToString();
                string company2 = DeliverableCreationRecord[76].ToString();
                string relationship2 = DeliverableCreationRecord[77].ToString();
                string email2 = DeliverableCreationRecord[78].ToString();
                string phone2 = DeliverableCreationRecord[79].ToString();
                string name3 = DeliverableCreationRecord[80].ToString();
                string title3 = DeliverableCreationRecord[81].ToString();
                string company3 = DeliverableCreationRecord[82].ToString();
                string relationship3 = DeliverableCreationRecord[83].ToString();
                string email3 = DeliverableCreationRecord[84].ToString();
                string phone3 = DeliverableCreationRecord[85].ToString();
                string name4 = DeliverableCreationRecord[86].ToString();
                string title4 = DeliverableCreationRecord[87].ToString();
                string company4 = DeliverableCreationRecord[88].ToString();
                string relationship4 = DeliverableCreationRecord[89].ToString();
                string email4 = DeliverableCreationRecord[90].ToString();
                string phone4 = DeliverableCreationRecord[91].ToString();
                string name5 = DeliverableCreationRecord[92].ToString();
                string title5 = DeliverableCreationRecord[93].ToString();
                string company5 = DeliverableCreationRecord[94].ToString();
                string relationship5 = DeliverableCreationRecord[95].ToString();
                string email5 = DeliverableCreationRecord[96].ToString();
                string phone5 = DeliverableCreationRecord[97].ToString();
                string name6 = DeliverableCreationRecord[98].ToString();
                string title6 = DeliverableCreationRecord[99].ToString();
                string company6 = DeliverableCreationRecord[100].ToString();
                string relationship6 = DeliverableCreationRecord[101].ToString();
                string email6 = DeliverableCreationRecord[102].ToString();
                string phone6 = DeliverableCreationRecord[103].ToString();
                string name7 = DeliverableCreationRecord[104].ToString();
                string title7 = DeliverableCreationRecord[105].ToString();
                string company7 = DeliverableCreationRecord[106].ToString();
                string relationship7 = DeliverableCreationRecord[107].ToString();
                string email7 = DeliverableCreationRecord[108].ToString();
                string phone7 = DeliverableCreationRecord[109].ToString();
                string name8 = DeliverableCreationRecord[110].ToString();
                string title8 = DeliverableCreationRecord[111].ToString();
                string company8 = DeliverableCreationRecord[112].ToString();
                string relationship8 = DeliverableCreationRecord[113].ToString();
                string email8 = DeliverableCreationRecord[114].ToString();
                string phone8 = DeliverableCreationRecord[115].ToString();


                fullName = fullName.Replace("&", "&amp;");
                degrees = degrees.Replace("&", "&amp;");
                streetAddress = streetAddress.Replace("&", "&amp;");
                cityStateZip = cityStateZip.Replace("&", "&amp;");
                emailAddress = emailAddress.Replace("&", "&amp;");
                phoneNumber = phoneNumber.Replace("&", "&amp;");
                name1 = name1.Replace("&", "&amp;");
                title1 = title1.Replace("&", "&amp;");
                company1 = company1.Replace("&", "&amp;");
                relationship1 = relationship1.Replace("&", "&amp;");
                email1 = email1.Replace("&", "&amp;");
                phone1 = phone1.Replace("&", "&amp;");
                name2 = name2.Replace("&", "&amp;");
                title2 = title2.Replace("&", "&amp;");
                company2 = company2.Replace("&", "&amp;");
                relationship2 = relationship2.Replace("&", "&amp;");
                email2 = email2.Replace("&", "&amp;");
                phone2 = phone2.Replace("&", "&amp;");
                name3 = name3.Replace("&", "&amp;");
                title3 = title3.Replace("&", "&amp;");
                company3 = company3.Replace("&", "&amp;");
                relationship3 = relationship3.Replace("&", "&amp;");
                email3 = email3.Replace("&", "&amp;");
                phone3 = phone3.Replace("&", "&amp;");
                name4 = name4.Replace("&", "&amp;");
                title4 = title4.Replace("&", "&amp;");
                company4 = company4.Replace("&", "&amp;");
                relationship4 = relationship4.Replace("&", "&amp;");
                email4 = email4.Replace("&", "&amp;");
                phone4 = phone4.Replace("&", "&amp;");
                name5 = name5.Replace("&", "&amp;");
                title5 = title5.Replace("&", "&amp;");
                company5 = company5.Replace("&", "&amp;");
                relationship5 = relationship5.Replace("&", "&amp;");
                email5 = email5.Replace("&", "&amp;");
                phone5 = phone5.Replace("&", "&amp;");
                name6 = name6.Replace("&", "&amp;");
                title6 = title6.Replace("&", "&amp;");
                company6 = company6.Replace("&", "&amp;");
                relationship6 = relationship6.Replace("&", "&amp;");
                email6 = email6.Replace("&", "&amp;");
                phone6 = phone6.Replace("&", "&amp;");
                name7 = name7.Replace("&", "&amp;");
                title7 = title7.Replace("&", "&amp;");
                company7 = company7.Replace("&", "&amp;");
                relationship7 = relationship7.Replace("&", "&amp;");
                email7 = email7.Replace("&", "&amp;");
                phone7 = phone7.Replace("&", "&amp;");
                name8 = name8.Replace("&", "&amp;");
                title8 = title8.Replace("&", "&amp;");
                company8 = company8.Replace("&", "&amp;");
                relationship8 = relationship8.Replace("&", "&amp;");
                email8 = email8.Replace("&", "&amp;");
                phone8 = phone8.Replace("&", "&amp;");


                fullName = fullName.Replace("<", "&lt;");
                degrees = degrees.Replace("<", "&lt;");
                streetAddress = streetAddress.Replace("<", "&lt;");
                cityStateZip = cityStateZip.Replace("<", "&lt;");
                emailAddress = emailAddress.Replace("<", "&lt;");
                phoneNumber = phoneNumber.Replace("<", "&lt;");
                name1 = name1.Replace("<", "&lt;");
                title1 = title1.Replace("<", "&lt;");
                company1 = company1.Replace("<", "&lt;");
                relationship1 = relationship1.Replace("<", "&lt;");
                email1 = email1.Replace("<", "&lt;");
                phone1 = phone1.Replace("<", "&lt;");
                name2 = name2.Replace("<", "&lt;");
                title2 = title2.Replace("<", "&lt;");
                company2 = company2.Replace("<", "&lt;");
                relationship2 = relationship2.Replace("<", "&lt;");
                email2 = email2.Replace("<", "&lt;");
                phone2 = phone2.Replace("<", "&lt;");
                name3 = name3.Replace("<", "&lt;");
                title3 = title3.Replace("<", "&lt;");
                company3 = company3.Replace("<", "&lt;");
                relationship3 = relationship3.Replace("<", "&lt;");
                email3 = email3.Replace("<", "&lt;");
                phone3 = phone3.Replace("<", "&lt;");
                name4 = name4.Replace("<", "&lt;");
                title4 = title4.Replace("<", "&lt;");
                company4 = company4.Replace("<", "&lt;");
                relationship4 = relationship4.Replace("<", "&lt;");
                email4 = email4.Replace("<", "&lt;");
                phone4 = phone4.Replace("<", "&lt;");
                name5 = name5.Replace("<", "&lt;");
                title5 = title5.Replace("<", "&lt;");
                company5 = company5.Replace("<", "&lt;");
                relationship5 = relationship5.Replace("<", "&lt;");
                email5 = email5.Replace("<", "&lt;");
                phone5 = phone5.Replace("<", "&lt;");
                name6 = name6.Replace("<", "&lt;");
                title6 = title6.Replace("<", "&lt;");
                company6 = company6.Replace("<", "&lt;");
                relationship6 = relationship6.Replace("<", "&lt;");
                email6 = email6.Replace("<", "&lt;");
                phone6 = phone6.Replace("<", "&lt;");
                name7 = name7.Replace("<", "&lt;");
                title7 = title7.Replace("<", "&lt;");
                company7 = company7.Replace("<", "&lt;");
                relationship7 = relationship7.Replace("<", "&lt;");
                email7 = email7.Replace("<", "&lt;");
                phone7 = phone7.Replace("<", "&lt;");
                name8 = name8.Replace("<", "&lt;");
                title8 = title8.Replace("<", "&lt;");
                company8 = company8.Replace("<", "&lt;");
                relationship8 = relationship8.Replace("<", "&lt;");
                email8 = email8.Replace("<", "&lt;");
                phone8 = phone8.Replace("<", "&lt;");


                fullName = fullName.Replace(">", "&gt;");
                degrees = degrees.Replace(">", "&gt;");
                streetAddress = streetAddress.Replace(">", "&gt;");
                cityStateZip = cityStateZip.Replace(">", "&gt;");
                emailAddress = emailAddress.Replace(">", "&gt;");
                phoneNumber = phoneNumber.Replace(">", "&gt;");
                name1 = name1.Replace(">", "&gt;");
                title1 = title1.Replace(">", "&gt;");
                company1 = company1.Replace(">", "&gt;");
                relationship1 = relationship1.Replace(">", "&gt;");
                email1 = email1.Replace(">", "&gt;");
                phone1 = phone1.Replace(">", "&gt;");
                name2 = name2.Replace(">", "&gt;");
                title2 = title2.Replace(">", "&gt;");
                company2 = company2.Replace(">", "&gt;");
                relationship2 = relationship2.Replace(">", "&gt;");
                email2 = email2.Replace(">", "&gt;");
                phone2 = phone2.Replace(">", "&gt;");
                name3 = name3.Replace(">", "&gt;");
                title3 = title3.Replace(">", "&gt;");
                company3 = company3.Replace(">", "&gt;");
                relationship3 = relationship3.Replace(">", "&gt;");
                email3 = email3.Replace(">", "&gt;");
                phone3 = phone3.Replace(">", "&gt;");
                name4 = name4.Replace(">", "&gt;");
                title4 = title4.Replace(">", "&gt;");
                company4 = company4.Replace(">", "&gt;");
                relationship4 = relationship4.Replace(">", "&gt;");
                email4 = email4.Replace(">", "&gt;");
                phone4 = phone4.Replace(">", "&gt;");
                name5 = name5.Replace(">", "&gt;");
                title5 = title5.Replace(">", "&gt;");
                company5 = company5.Replace(">", "&gt;");
                relationship5 = relationship5.Replace(">", "&gt;");
                email5 = email5.Replace(">", "&gt;");
                phone5 = phone5.Replace(">", "&gt;");
                name6 = name6.Replace(">", "&gt;");
                title6 = title6.Replace(">", "&gt;");
                company6 = company6.Replace(">", "&gt;");
                relationship6 = relationship6.Replace(">", "&gt;");
                email6 = email6.Replace(">", "&gt;");
                phone6 = phone6.Replace(">", "&gt;");
                name7 = name7.Replace(">", "&gt;");
                title7 = title7.Replace(">", "&gt;");
                company7 = company7.Replace(">", "&gt;");
                relationship7 = relationship7.Replace(">", "&gt;");
                email7 = email7.Replace(">", "&gt;");
                phone7 = phone7.Replace(">", "&gt;");
                name8 = name8.Replace(">", "&gt;");
                title8 = title8.Replace(">", "&gt;");
                company8 = company8.Replace(">", "&gt;");
                relationship8 = relationship8.Replace(">", "&gt;");
                email8 = email8.Replace(">", "&gt;");
                phone8 = phone8.Replace(">", "&gt;");


                fullName = fullName.Replace("\"", "&quot;");
                degrees = degrees.Replace("\"", "&quot;");
                streetAddress = streetAddress.Replace("\"", "&quot;");
                cityStateZip = cityStateZip.Replace("\"", "&quot;");
                emailAddress = emailAddress.Replace("\"", "&quot;");
                phoneNumber = phoneNumber.Replace("\"", "&quot;");
                name1 = name1.Replace("\"", "&quot;");
                title1 = title1.Replace("\"", "&quot;");
                company1 = company1.Replace("\"", "&quot;");
                relationship1 = relationship1.Replace("\"", "&quot;");
                email1 = email1.Replace("\"", "&quot;");
                phone1 = phone1.Replace("\"", "&quot;");
                name2 = name2.Replace("\"", "&quot;");
                title2 = title2.Replace("\"", "&quot;");
                company2 = company2.Replace("\"", "&quot;");
                relationship2 = relationship2.Replace("\"", "&quot;");
                email2 = email2.Replace("\"", "&quot;");
                phone2 = phone2.Replace("\"", "&quot;");
                name3 = name3.Replace("\"", "&quot;");
                title3 = title3.Replace("\"", "&quot;");
                company3 = company3.Replace("\"", "&quot;");
                relationship3 = relationship3.Replace("\"", "&quot;");
                email3 = email3.Replace("\"", "&quot;");
                phone3 = phone3.Replace("\"", "&quot;");
                name4 = name4.Replace("\"", "&quot;");
                title4 = title4.Replace("\"", "&quot;");
                company4 = company4.Replace("\"", "&quot;");
                relationship4 = relationship4.Replace("\"", "&quot;");
                email4 = email4.Replace("\"", "&quot;");
                phone4 = phone4.Replace("\"", "&quot;");
                name5 = name5.Replace("\"", "&quot;");
                title5 = title5.Replace("\"", "&quot;");
                company5 = company5.Replace("\"", "&quot;");
                relationship5 = relationship5.Replace("\"", "&quot;");
                email5 = email5.Replace("\"", "&quot;");
                phone5 = phone5.Replace("\"", "&quot;");
                name6 = name6.Replace("\"", "&quot;");
                title6 = title6.Replace("\"", "&quot;");
                company6 = company6.Replace("\"", "&quot;");
                relationship6 = relationship6.Replace("\"", "&quot;");
                email6 = email6.Replace("\"", "&quot;");
                phone6 = phone6.Replace("\"", "&quot;");
                name7 = name7.Replace("\"", "&quot;");
                title7 = title7.Replace("\"", "&quot;");
                company7 = company7.Replace("\"", "&quot;");
                relationship7 = relationship7.Replace("\"", "&quot;");
                email7 = email7.Replace("\"", "&quot;");
                phone7 = phone7.Replace("\"", "&quot;");
                name8 = name8.Replace("\"", "&quot;");
                title8 = title8.Replace("\"", "&quot;");
                company8 = company8.Replace("\"", "&quot;");
                relationship8 = relationship8.Replace("\"", "&quot;");
                email8 = email8.Replace("\"", "&quot;");
                phone8 = phone8.Replace("\"", "&quot;");


                fullName = fullName.Replace("'", "&apos;");
                degrees = degrees.Replace("'", "&apos;");
                streetAddress = streetAddress.Replace("'", "&apos;");
                cityStateZip = cityStateZip.Replace("'", "&apos;");
                emailAddress = emailAddress.Replace("'", "&apos;");
                phoneNumber = phoneNumber.Replace("'", "&apos;");
                name1 = name1.Replace("'", "&apos;");
                title1 = title1.Replace("'", "&apos;");
                company1 = company1.Replace("'", "&apos;");
                relationship1 = relationship1.Replace("'", "&apos;");
                email1 = email1.Replace("'", "&apos;");
                phone1 = phone1.Replace("'", "&apos;");
                name2 = name2.Replace("'", "&apos;");
                title2 = title2.Replace("'", "&apos;");
                company2 = company2.Replace("'", "&apos;");
                relationship2 = relationship2.Replace("'", "&apos;");
                email2 = email2.Replace("'", "&apos;");
                phone2 = phone2.Replace("'", "&apos;");
                name3 = name3.Replace("'", "&apos;");
                title3 = title3.Replace("'", "&apos;");
                company3 = company3.Replace("'", "&apos;");
                relationship3 = relationship3.Replace("'", "&apos;");
                email3 = email3.Replace("'", "&apos;");
                phone3 = phone3.Replace("'", "&apos;");
                name4 = name4.Replace("'", "&apos;");
                title4 = title4.Replace("'", "&apos;");
                company4 = company4.Replace("'", "&apos;");
                relationship4 = relationship4.Replace("'", "&apos;");
                email4 = email4.Replace("'", "&apos;");
                phone4 = phone4.Replace("'", "&apos;");
                name5 = name5.Replace("'", "&apos;");
                title5 = title5.Replace("'", "&apos;");
                company5 = company5.Replace("'", "&apos;");
                relationship5 = relationship5.Replace("'", "&apos;");
                email5 = email5.Replace("'", "&apos;");
                phone5 = phone5.Replace("'", "&apos;");
                name6 = name6.Replace("'", "&apos;");
                title6 = title6.Replace("'", "&apos;");
                company6 = company6.Replace("'", "&apos;");
                relationship6 = relationship6.Replace("'", "&apos;");
                email6 = email6.Replace("'", "&apos;");
                phone6 = phone6.Replace("'", "&apos;");
                name7 = name7.Replace("'", "&apos;");
                title7 = title7.Replace("'", "&apos;");
                company7 = company7.Replace("'", "&apos;");
                relationship7 = relationship7.Replace("'", "&apos;");
                email7 = email7.Replace("'", "&apos;");
                phone7 = phone7.Replace("'", "&apos;");
                name8 = name8.Replace("'", "&apos;");
                title8 = title8.Replace("'", "&apos;");
                company8 = company8.Replace("'", "&apos;");
                relationship8 = relationship8.Replace("'", "&apos;");
                email8 = email8.Replace("'", "&apos;");
                phone8 = phone8.Replace("'", "&apos;");
                

                _doc = _doc.Replace(fullNameTag, fullName);
                _doc = _doc.Replace(degreesTag, degrees);
                _doc = _doc.Replace(streetAddressTag, streetAddress);
                _doc = _doc.Replace(cityStateZipTag, cityStateZip);
                _doc = _doc.Replace(emailAddressTag, emailAddress);
                _doc = _doc.Replace(phoneNumberTag, phoneNumber);
                _doc = _doc.Replace(name1Tag, name1);
                _doc = _doc.Replace(title1Tag, title1);
                _doc = _doc.Replace(company1Tag, company1);
                _doc = _doc.Replace(relationship1Tag, relationship1);
                _doc = _doc.Replace(email1Tag, email1);
                _doc = _doc.Replace(phone1Tag, phone1);
                _doc = _doc.Replace(name2Tag, name2);
                _doc = _doc.Replace(title2Tag, title2);
                _doc = _doc.Replace(company2Tag, company2);
                _doc = _doc.Replace(relationship2Tag, relationship2);
                _doc = _doc.Replace(email2Tag, email2);
                _doc = _doc.Replace(phone2Tag, phone2);
                _doc = _doc.Replace(name3Tag, name3);
                _doc = _doc.Replace(title3Tag, title3);
                _doc = _doc.Replace(company3Tag, company3);
                _doc = _doc.Replace(relationship3Tag, relationship3);
                _doc = _doc.Replace(email3Tag, email3);
                _doc = _doc.Replace(phone3Tag, phone3);
                _doc = _doc.Replace(name4Tag, name4);
                _doc = _doc.Replace(title4Tag, title4);
                _doc = _doc.Replace(company4Tag, company4);
                _doc = _doc.Replace(relationship4Tag, relationship4);
                _doc = _doc.Replace(email4Tag, email4);
                _doc = _doc.Replace(phone4Tag, phone4);
                _doc = _doc.Replace(name5Tag, name5);
                _doc = _doc.Replace(title5Tag, title5);
                _doc = _doc.Replace(company5Tag, company5);
                _doc = _doc.Replace(relationship5Tag, relationship5);
                _doc = _doc.Replace(email5Tag, email5);
                _doc = _doc.Replace(phone5Tag, phone5);
                _doc = _doc.Replace(name6Tag, name6);
                _doc = _doc.Replace(title6Tag, title6);
                _doc = _doc.Replace(company6Tag, company6);
                _doc = _doc.Replace(relationship6Tag, relationship6);
                _doc = _doc.Replace(email6Tag, email6);
                _doc = _doc.Replace(phone6Tag, phone6);
                _doc = _doc.Replace(name7Tag, name7);
                _doc = _doc.Replace(title7Tag, title7);
                _doc = _doc.Replace(company7Tag, company7);
                _doc = _doc.Replace(relationship7Tag, relationship7);
                _doc = _doc.Replace(email7Tag, email7);
                _doc = _doc.Replace(phone7Tag, phone7);
                _doc = _doc.Replace(name8Tag, name8);
                _doc = _doc.Replace(title8Tag, title8);
                _doc = _doc.Replace(company8Tag, company8);
                _doc = _doc.Replace(relationship8Tag, relationship8);
                _doc = _doc.Replace(email8Tag, email8);
                _doc = _doc.Replace(phone8Tag, phone8);
                

                File.WriteAllText(SavePath, _doc);

            }//end try

            catch (Exception ex)
            {
                string errorMessage = "Marketing Documents Creation Error: " + ex.Message.ToString();

                deliverableCreationObject.setErrorMessage(errorMessage);

            }//end catch

            return deliverableCreationObject.getErrorMessage();

        }//end method

    }//end class

}//end namespace