using MasterPlan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterPlan.Controllers
{
    public class PlanController : Controller
    {
      
        //
        // GET: /Plan/

        public ActionResult SimplePlan(int? id)
        {
            SimplePlanModel model = Session["plan"] as SimplePlanModel;
            if (id != null)
            {
                switch(id)
                {
                    case 0: ViewBag.Title = "Title";
                        ViewBag.Message = "Write the name of your organisation and the duration of the planning period.";
                        break;
                    case 1: ViewBag.Title = "WHAT BUSINESS ARE YOU IN?";
                        ViewBag.Message = "Provide a general outline of your business, sufficient for outsiders to fully understand what your business is all about.  Which industry is it in?  What is the major benefit, rather than product or service, that you provide to your customers?";
                        break;
                    case 2: ViewBag.Title = "WHAT ARE THE UNIQUE FEATURES OF YOUR BUSINESS'S PRODUCTS OR SERVICES?";
                        ViewBag.Message = "Discuss product or service advantages that give you an edge in the market.  Is your product or service substantially better than your competitors?  Does it offer the best, the fastest, the most powerful, the cleanest or the most efficient solution?.";
                        break;
                    case 3: ViewBag.Title = "WHAT WERE YOUR SALES LAST YEAR AND OVER THE LAST FEW YEARS? HOW WELL HAVE YOU PERFORMED?  IF YOU HAVE NOT PERFORMED TO BUDGET, INDICATE WHY NOT?";
                        ViewBag.Message = "This provides a background to your sales situation and a lead-in to the future of the business.  For instance, you may include something like \"Although our sales have increasd by ten percent a year over the last three years we have never really taken advantage of the opportunities available.  This plan is being prepared to enable us to do so in the future.\"";
                        break;
                    case 4: ViewBag.Title = "WHAT ARE YOUR PROJECTED SALES AND PROFITS FOR THE NEXT THREE YEARS?";
                        ViewBag.Message = "This is the bottom line.  How much profit are you going to make? Insert graph here, illustrating your sales growth, as it would look very impressive.";
                        break;
                    case 5: ViewBag.Title = "WHAT PROOF CAN YOU PROVIDE THAT YOU WILL ACHIEVE THIS LEVEL OF SALES AND PROFIT?";
                        ViewBag.Message = "Back up your forecasts with some form of evidence that there will be continuing demand for your goods or services.  Do you have any advance orders, existing customers that have promised to use your goods or services, market research surveys or sales experience in this industry that implies a natural growth in the market.  Do you have evidence of any external factors such as changes in legislation, competitor status or cultural influences that will lead to a demand for your products or services? Add anything that re-inforces the proposition that you will be successful.  For instance, mention any large orders you have received in the past or perhaps profile some existing customers.  List those things which may add credibility to your business.";
                        break;
                    case 6: ViewBag.Title = "HOW BIG IS THE TOTAL MARKET?  IS THE MARKET GROWING OR DECLINING?";
                        ViewBag.Message = "Explain who will buy your products or services.  Is this a good, strong, growing market or is it declining?  If it is declining you should consider diversifying into other markets.Sometimes the figures on total market size are irrelevant, especially when a business is only a small fish in a very big pond.  For instance, a plumber who has just set up shop will probably get no help from knowing the size of the total plumbing market.  However, if he is a one-man plumbing business in a particular suburb and specialising in a particular area, it would be worthwhile him knowing how big the market is in the area, how many competitors there are and how many specialise in the same services as he does.";
                        break;
                    case 7: ViewBag.Title = "CAN THE TOTAL MARKET BE BROKEN DOWN INTO SMALLER SUB-MARKETS OR MARKET SEGMENTS ?";
                        ViewBag.Message = "Try to break down the total market into smaller segments.  This will help to develop your plans and competitively position your products and services.  Examples of segmentation, which show you exactly how to do this are included in your workbook (User Manual).A quick example: If you are selling computers you might segment your market into large businesses, small businesses, the home buyer, government bodies and students.  When you break down your market into smaller segments such as this it is easier for you to decide how to sell your goods or services to each segment.  For example, you may need to sell your computers at a low price to students and to sell them through the university magazine.  However, to government bodies price would be less of a consideration than reliability.  You may also need to employ a sales rep to sell effectively to government bodies.";
                        break;
                    case 8: ViewBag.Title = "ARE THERE ANY MARKET TRENDS THAT WILL AFFECT YOUR BUSINESS?";
                        ViewBag.Message = "It is very important to know and recognise the trends and the external factors that could affect the market, so you can asses whether or not your business will be viable in the long term.  Are there any cultural, legislative, social, environmental, technological or other influences that may affect your business?  For example, technological influencers have made typewriters, telexes and buggies almost obsolete.  Environmental and social issues have seriously affected the plastics industry by forcing companies who were using plastic-based packaging to find alternatives.  There are trends in the market for following a more healthy low-fat lifestyle.  The hat market will increase in coming years because of awareness of the deteriorating ozone level.  Look at your products, services and markets and asses whether there are any potential threats or opportunities that could affect your planning.";
                        break;
                    case 9: ViewBag.Title = "HOW DO YOU COMPARE TO YOUR COMPETITORS?";
                        ViewBag.Message = "If you use the sample text then the lables on the left hand side of the box below are examples only.  Change them to suit your company.";
                        break;
                    case 10: ViewBag.Title = "WRITE DOWN YOUR STRENGTHS,  WEAKNESSES, OPPORTUNITIES AND THREATS.";
                        ViewBag.Message = "This is a snapshot of your business. Just write down the most important points. The better your SWOT analysis the easier it will be to plan. For instance, if your SWOT analysis states that your company has a low quality product, then one of your objectives might be to \"improve product quality through better quality control measures.\"";
                        break;
                    case 11: ViewBag.Title = "WHERE ARE YOU HEADED?";
                        ViewBag.Message = "This should be a clear concise statement of where you are headed. It should state where your company will be in 3-5 years time.";
                        break;
                    case 12: ViewBag.Title = "TARGET MARKETS (WHO WILL BUY YOUR PRODUCTS/SERVICES?)";
                        ViewBag.Message = "Based on the market trends, profiles of your business and your competitors, who exactly will you sell your products and services to?  What market represents the best chance of success?  Where are the opportunites?";
                        break;
                    case 13: ViewBag.Title = "HOW WILL YOU POSITION YOUR BUSINESS'S PRODUCTS OR SERVICES AGAINST YOUR COMPETITORS?  IS THERE A GAP IN THE MARKET?";
                        ViewBag.Message = "Why will people buy your goods or services?  Are you offering the same as everyone else is or something that is substantially different and that fills a need in the market?  There could be a gap in the market.  I.e. No competitors that sell similar goods or services at a price that you are prepared to sell at or no-one else that has a particular feature or distributes their product in the same manner as you do.  In a previous question you looked at the features of your products and services - in this section you should look at the benefits to the customers of these features and whether your competitors can provide the same benefits.This is an explanation of why you will win!  Discuss any major product or service advantages that give you an edge in the market place.  For instance, all watches tell the time but each manufacturer positions its products differently.  People buy Swatch watches beacuse they are fashionable and Rolex watches because of their image.  Isolate the unique feature of your products or services - this is called your competitive advantage. A service business would do the same.  For instance, a gardener's competitive advantage might be to offer fixed price services.  This gives the customer security of price - they know exactly what the service will cost from the start.  The gardener could also offer garbage removal, lawn mowing and pool cleaning.  The benefit to the customer is ease of purchase.  They can order all these services with one phone call, pay with one cheque and have a familiar face doing all the work. ";
                        break;
                    case 14: ViewBag.Title = "WHAT ARE THE MAJOR THINGS THAT YOU WILL NEED TO ACHIEVE IN ORDER TO MEET THESE FINANCIAL RETURNS? ";
                        ViewBag.Message = "This is a brief outline of all the things to come. E.g. \"We will increase our advertising expenditure, invest in a new machine, improve our distribution by appointing a freight agency and better target our product to the consumer based on the results of our market research campaign\".  If you are applying for funding for capital expenditure highlight what the funds will be used for.";
                        break;
                    case 15: ViewBag.Title = "INVESTOR INFORMATION.";
                        ViewBag.Message = "If presenting to outside investors or bank, how much do you wish to borrow and what will be the return on investment? What specifically, do you need financing for?";
                        break;
                    case 16: ViewBag.Title = "WHAT ARE YOUR OBJECTIVES FOR THE ORGANISATION?";
                        ViewBag.Message = "Your objectives should always be measurable and quantifiable. They should state what you are trying to achieve. For instance, I will sell $50,000 per month of product A, I will make a 25% gross margin and a 10% net profit.";
                        break;
                    case 17: ViewBag.Title = "WRITE YOUR MARKETING PLAN.";
                        ViewBag.Message = "";
                        break;
                    case 18: ViewBag.Title = "WRITE YOUR FINANCIAL PLAN.";
                        ViewBag.Message = "";
                        break;
                    case 19: ViewBag.Title = "WRITE YOUR ORGANISATIONAL PLAN.";
                        ViewBag.Message = "";
                        break;
                    case 20: ViewBag.Title = "WRITE ANY OTHER COMPANY PLANS.";
                        ViewBag.Message = "";
                        break;
                    case 21: ViewBag.Title = "";
                        ViewBag.Message = "";
                        break;
                }
                ViewData["TextEditor"] = "true";
            }

            return View(model);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SimplePlan(FormCollection collection)
        {
            SimplePlanModel model = Session["plan"] as SimplePlanModel;
            model.Title = collection["textArea"];
            return View(model);
        }

    }
}
