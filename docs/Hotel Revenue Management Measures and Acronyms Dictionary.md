# Hotel Revenue Management Measures and Acronyms Dictionary

## Relationship Between DAX Measures and Visualizations

### 1. Why were some measures created but not included in visualizations?

The DAX measures in the C# script were created as a comprehensive library of metrics for hotel revenue management analysis. Not all measures were directly used in the visualizations for several reasons:

1. **Supporting calculations**: Some measures serve as intermediate calculations that support other visualized metrics
2. **Analytical depth**: The complete set of measures provides analytical depth for ad-hoc analysis beyond the predefined visualizations
3. **Drill-through functionality**: Many measures are used in drill-through pages and tooltips rather than primary visualizations
4. **Flexibility for future expansion**: The comprehensive measure library allows for easy dashboard expansion without needing to create new measures
5. **Different analysis perspectives**: The measures support multiple analytical perspectives (operational, financial, customer-focused) that can be toggled between

### 2. Why not create additional visualizations for these measures?

Additional visualizations for all measures weren't created for these reasons:

1. **Dashboard focus**: Each dashboard page needs a clear focus to be effective; too many visualizations dilute the key insights
2. **Information overload**: Including all measures would create information overload for users
3. **Performance considerations**: More visualizations impact dashboard performance
4. **Progressive disclosure**: Best practice is to show high-level metrics first, then allow users to drill down for details
5. **User experience**: The dashboard was designed to provide the most important insights while maintaining usability

## Hotel Revenue Management Acronyms and Metrics Dictionary

### Key Performance Indicators (KPIs)

| Acronym/Metric | Full Name | Definition | Importance |
|---------------|-----------|------------|------------|
| ADR | Average Daily Rate | The average rate charged per occupied room, calculated as room revenue divided by number of rooms sold | Critical for pricing strategy and revenue optimization; indicates how well a hotel is maximizing room rates |
| RevPAR | Revenue Per Available Room | Total room revenue divided by total available rooms; combines occupancy and rate performance | Industry standard for measuring overall revenue performance; balances rate and occupancy |
| TRevPAR | Total Revenue Per Available Room | Total revenue (including non-room) divided by total available rooms | Provides a more comprehensive view of revenue performance including all revenue streams |
| GOPPAR | Gross Operating Profit Per Available Room | Gross operating profit divided by total available rooms | Measures profitability per room, accounting for both revenue and costs |
| OTA | Online Travel Agency | Third-party booking platforms like Expedia, Booking.com | Important to track as these channels typically charge commissions that impact profitability |
| YOY | Year Over Year | Comparison of metrics with the same period in the previous year | Essential for understanding long-term trends and seasonal patterns |
| MTD | Month To Date | Cumulative performance from the beginning of the current month | Helps track progress toward monthly targets |
| QTD | Quarter To Date | Cumulative performance from the beginning of the current quarter | Helps track progress toward quarterly targets |
| YTD | Year To Date | Cumulative performance from the beginning of the current year | Helps track progress toward annual targets |

### Revenue Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Total_Revenue | Sum of all revenue sources | Primary measure of overall business performance |
| Room_Revenue | Revenue generated from room sales only | Core revenue stream for most hotels |
| Non_Room_Revenue | Revenue from sources other than rooms (F&B, spa, etc.) | Important for understanding ancillary revenue opportunities |
| Previous_Month_Revenue | Revenue from the previous month | Provides context for month-over-month growth |
| YOY_Revenue | Revenue from the same period last year | Essential for seasonal business comparison |
| Revenue_Growth_Pct | Percentage change in revenue compared to previous period | Key indicator of business growth or decline |
| Revenue_Per_Booking | Average revenue generated per booking | Measures effectiveness of upselling and cross-selling |
| Revenue_MTD/QTD/YTD | Cumulative revenue for month/quarter/year to date | Tracks progress toward period targets |

### Occupancy Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Occupancy_Rate | Percentage of available rooms that are occupied | Fundamental measure of demand and capacity utilization |
| Weekend_Occupancy | Occupancy rate specifically for weekend days | Helps optimize pricing for leisure-dominated periods |
| Weekday_Occupancy | Occupancy rate specifically for weekday days | Helps optimize pricing for business-dominated periods |
| Holiday_Occupancy | Occupancy rate on public holidays | Identifies special pricing opportunities |
| Occupancy_YOY_Change | Year-over-year change in occupancy rate | Indicates long-term demand trends |

### Pricing Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| ADR | Average daily rate | Key pricing metric |
| ADR_By_Season | Average daily rate broken down by season | Helps identify seasonal pricing opportunities |
| ADR_By_Day_Of_Week | Average daily rate broken down by day of week | Helps optimize day-of-week pricing strategies |
| ADR_YOY_Change_Pct | Year-over-year percentage change in ADR | Indicates pricing trend and potential rate growth |
| RevPAR_YOY_Change_Pct | Year-over-year percentage change in RevPAR | Indicates overall revenue performance trend |

### Market Segmentation Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Leisure_Revenue | Revenue from leisure guests | Helps understand contribution of leisure segment |
| Business_Revenue | Revenue from business guests | Helps understand contribution of business segment |
| Leisure_Occupancy | Occupancy rate for leisure guests | Indicates demand from leisure travelers |
| Business_Occupancy | Occupancy rate for business guests | Indicates demand from business travelers |
| Leisure_ADR | Average daily rate for leisure guests | Helps optimize pricing for leisure segment |
| Business_ADR | Average daily rate for business guests | Helps optimize pricing for business segment |
| Leisure_Revenue_Pct | Percentage of total revenue from leisure guests | Shows relative importance of leisure segment |
| Business_Revenue_Pct | Percentage of total revenue from business guests | Shows relative importance of business segment |

### Distribution Channel Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Direct_Revenue | Revenue from direct bookings | Revenue from highest-margin channel |
| OTA_Revenue | Revenue from online travel agency bookings | Revenue from third-party channels that typically charge commission |
| Direct_Bookings | Number of bookings from direct channel | Volume indicator for direct channel performance |
| OTA_Bookings | Number of bookings from OTA channel | Volume indicator for OTA channel performance |
| Direct_ADR | Average daily rate for direct bookings | Pricing performance in direct channel |
| OTA_ADR | Average daily rate for OTA bookings | Pricing performance in OTA channel |
| Direct_Revenue_Pct | Percentage of total revenue from direct bookings | Indicates channel mix and potential for margin improvement |
| OTA_Revenue_Pct | Percentage of total revenue from OTA bookings | Indicates dependency on third-party channels |

### Profitability Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Total_Profit | Sum of all profit | Bottom-line performance measure |
| Profit_Margin | Profit as a percentage of revenue | Efficiency of converting revenue to profit |
| Total_Costs | Sum of all costs | Overall cost structure |
| Cost_Per_Room | Average cost per occupied room | Efficiency of service delivery |
| Marketing_Efficiency | Revenue generated per dollar of marketing spend | ROI on marketing investment |
| Profit_Per_Room | Average profit per occupied room | Profitability at the room level |
| Profit_YOY_Change_Pct | Year-over-year percentage change in profit | Long-term profitability trend |

### Customer Satisfaction Metrics

| Metric | Definition | Importance |
|--------|------------|------------|
| Avg_Review_Score | Average customer review score | Overall guest satisfaction indicator |
| Total_Complaints | Total number of customer complaints | Negative feedback volume |
| Total_Compliments | Total number of customer compliments | Positive feedback volume |
| Complaints_Per_100_Bookings | Number of complaints per 100 bookings | Normalized complaint rate |
| Compliments_Per_100_Bookings | Number of compliments per 100 bookings | Normalized compliment rate |
| Satisfaction_Ratio | Ratio of compliments to complaints | Balance of positive to negative feedback |
| Review_Score_YOY_Change | Year-over-year change in average review score | Long-term satisfaction trend |

## Hotel Book.csv Column Definitions

| Column Name | Definition | Purpose in Analysis |
|-------------|------------|---------------------|
| Date | Calendar date of the data | Primary time dimension for trend analysis |
| Month | Numeric representation of the month (1-12) | Aggregation for monthly analysis |
| Weekday | Day of the week (1-7, where 1 is Monday) | Analysis of day-of-week patterns |
| Season | Categorical season (Winter, Spring, Summer, Fall) | Seasonal trend analysis |
| Holiday | Binary flag (1=holiday, 0=regular day) | Impact analysis of holidays |
| Marketing_Spend | Amount spent on marketing activities | Marketing ROI analysis |
| Revenue | Total revenue for the day (may be deprecated, use Total_Revenue) | Legacy column |
| Room_Revenue | Revenue from room sales only | Core revenue analysis |
| Occupancy_Rate | Percentage of available rooms occupied | Demand analysis |
| ADR | Average Daily Rate | Pricing analysis |
| RevPAR | Revenue Per Available Room | Combined rate and occupancy performance |
| Available_Rooms | Number of rooms available for sale | Capacity metric |
| Reserved_Rooms | Number of rooms reserved | Booking volume |
| Booking_Channel | Source of booking (Direct, OTA) | Distribution channel analysis |
| Guest_Type | Type of guest (Leisure, Business) | Market segmentation analysis |
| Market_Segment | Numeric value representing market segment percentage | Market mix analysis |
| Guest_Country | Country of origin for guests | Geographic segmentation |
| Complaints | Number of complaints received | Service quality indicator |
| Compliment | Number of compliments received | Service excellence indicator |
| Bookings | Total number of bookings | Demand volume |
| No_Shows | Number of guests who didn't arrive | Operational inefficiency |
| Cancellations | Number of cancelled bookings | Booking stability |
| Checkouts | Number of guests checking out | Departure volume |
| New_Bookings | Number of new bookings received | New demand |
| Checkins | Number of guests checking in | Arrival volume |
| Average_Review_Score | Average guest satisfaction score (0-5) | Guest satisfaction metric |
| Revenue_Managed_Guests | Revenue from guests under revenue management | Revenue management effectiveness |
| RevPAR_Managed_Guests | RevPAR for revenue-managed guests | Revenue management performance |
| Occupancy_Managed_Guests | Occupancy rate for revenue-managed guests | Revenue management impact on occupancy |
| RevPAR_All | RevPAR for all guests (may be redundant with RevPAR) | Overall RevPAR |
| Occupancy_All | Occupancy rate for all guests (may be redundant with Occupancy_Rate) | Overall occupancy |
| Room_Revenue_All | Room revenue for all guests (may be redundant with Room_Revenue) | Overall room revenue |
| Total_Revenue | Total revenue across all sources | Primary revenue metric |
| Operating_Expenses | Daily operating expenses | Variable cost analysis |
| Fixed_Costs | Daily fixed costs | Fixed cost analysis |
| Variable_Costs | Daily variable costs | Variable cost analysis |
| Total_Costs | Sum of all costs | Overall cost structure |
| Profit | Revenue minus costs | Bottom-line performance |
