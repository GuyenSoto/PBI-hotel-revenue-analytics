// Simplified C# script for importing DAX measures into Tabular Editor 2.26.0
// Custom implementation for Hotel Revenue Management Analysis

// Configuration
string targetTableName = "All_Measures";

// =========================================================
// Hotel Revenue Management DAX Measures Definition
// =========================================================

// Define measures in format: [Name], [DAX Expression], [Description], [Folder]
var measures = new[] {
    // Revenue Measures
    new { Name = "Total_Revenue", Expression = "SUM(HotelOperations[Total_Revenue])", Description = "Total revenue across all sources", Folder = "Revenue Metrics" },
    new { Name = "Room_Revenue", Expression = "SUM(HotelOperations[Room_Revenue])", Description = "Revenue from room bookings only", Folder = "Revenue Metrics" },
    new { Name = "Non_Room_Revenue", Expression = "SUM(HotelOperations[Total_Revenue]) - SUM(HotelOperations[Room_Revenue])", Description = "Revenue from sources other than room bookings", Folder = "Revenue Metrics" },
    new { Name = "Previous_Month_Revenue", Expression = "CALCULATE([Total_Revenue], DATEADD(DateDim[Date], -1, MONTH))", Description = "Revenue from the previous month", Folder = "Revenue Metrics" },
    new { Name = "YOY_Revenue", Expression = "CALCULATE([Total_Revenue], DATEADD(DateDim[Date], -1, YEAR))", Description = "Revenue from the same period last year", Folder = "Revenue Metrics" },
    new { Name = "Revenue_Growth_Pct", Expression = "VAR CurrentRev = [Total_Revenue] VAR PrevRev = [Previous_Month_Revenue] RETURN IF(PrevRev = 0, BLANK(), DIVIDE(CurrentRev - PrevRev, PrevRev))", Description = "Month-over-month revenue growth percentage", Folder = "Revenue Metrics" },
    new { Name = "YOY_Revenue_Growth_Pct", Expression = "VAR CurrentRev = [Total_Revenue] VAR PrevYearRev = [YOY_Revenue] RETURN IF(PrevYearRev = 0, BLANK(), DIVIDE(CurrentRev - PrevYearRev, PrevYearRev))", Description = "Year-over-year revenue growth percentage", Folder = "Revenue Metrics" },
    new { Name = "Revenue_Per_Booking", Expression = "DIVIDE([Total_Revenue], SUM(HotelOperations[Bookings]), 0)", Description = "Average revenue per booking", Folder = "Revenue Metrics" },
    
    // Occupancy Metrics
    new { Name = "Occupancy_Rate", Expression = "AVERAGE(HotelOperations[Occupancy_Rate])", Description = "Average occupancy rate", Folder = "Occupancy Metrics" },
    new { Name = "Weekend_Occupancy", Expression = "CALCULATE([Occupancy_Rate], DateDim[Is_Weekend] = TRUE)", Description = "Average occupancy rate on weekends", Folder = "Occupancy Metrics" },
    new { Name = "Weekday_Occupancy", Expression = "CALCULATE([Occupancy_Rate], DateDim[Is_Weekend] = FALSE)", Description = "Average occupancy rate on weekdays", Folder = "Occupancy Metrics" },
    new { Name = "Holiday_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Holiday] = 1)", Description = "Average occupancy rate on holidays", Folder = "Occupancy Metrics" },
    new { Name = "Non_Holiday_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Holiday] = 0)", Description = "Average occupancy rate on non-holidays", Folder = "Occupancy Metrics" },
    new { Name = "Occupancy_YOY_Change", Expression = "VAR CurrentOcc = [Occupancy_Rate] VAR PrevYearOcc = CALCULATE([Occupancy_Rate], DATEADD(DateDim[Date], -1, YEAR)) RETURN CurrentOcc - PrevYearOcc", Description = "Year-over-year change in occupancy rate (percentage points)", Folder = "Occupancy Metrics" },
    
    // Pricing Metrics
    new { Name = "ADR", Expression = "AVERAGE(HotelOperations[ADR])", Description = "Average daily rate", Folder = "Pricing Metrics" },
    new { Name = "RevPAR", Expression = "DIVIDE([Total_Revenue], SUM(HotelOperations[Available_Rooms]), 0)", Description = "Revenue per available room", Folder = "Pricing Metrics" },
    new { Name = "ADR_By_Season", Expression = "AVERAGEX(VALUES(HotelOperations[Season]), [ADR])", Description = "Average daily rate by season", Folder = "Pricing Metrics" },
    new { Name = "ADR_By_Day_Of_Week", Expression = "AVERAGEX(VALUES(DateDim[Weekday_Name]), [ADR])", Description = "Average daily rate by day of week", Folder = "Pricing Metrics" },
    new { Name = "ADR_YOY_Change_Pct", Expression = "VAR CurrentADR = [ADR] VAR PrevYearADR = CALCULATE([ADR], DATEADD(DateDim[Date], -1, YEAR)) RETURN IF(PrevYearADR = 0, BLANK(), DIVIDE(CurrentADR - PrevYearADR, PrevYearADR))", Description = "Year-over-year change in ADR (percentage)", Folder = "Pricing Metrics" },
    new { Name = "RevPAR_YOY_Change_Pct", Expression = "VAR CurrentRevPAR = [RevPAR] VAR PrevYearRevPAR = CALCULATE([RevPAR], DATEADD(DateDim[Date], -1, YEAR)) RETURN IF(PrevYearRevPAR = 0, BLANK(), DIVIDE(CurrentRevPAR - PrevYearRevPAR, PrevYearRevPAR))", Description = "Year-over-year change in RevPAR (percentage)", Folder = "Pricing Metrics" },
    
    // Market Segmentation Metrics
    new { Name = "Leisure_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Guest_Type] = \"Leisure\")", Description = "Total revenue from leisure guests", Folder = "Market Segmentation" },
    new { Name = "Business_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Guest_Type] = \"Business\")", Description = "Total revenue from business guests", Folder = "Market Segmentation" },
    new { Name = "Leisure_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Guest_Type] = \"Leisure\")", Description = "Occupancy rate for leisure guests", Folder = "Market Segmentation" },
    new { Name = "Business_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Guest_Type] = \"Business\")", Description = "Occupancy rate for business guests", Folder = "Market Segmentation" },
    new { Name = "Leisure_ADR", Expression = "CALCULATE([ADR], HotelOperations[Guest_Type] = \"Leisure\")", Description = "ADR for leisure guests", Folder = "Market Segmentation" },
    new { Name = "Business_ADR", Expression = "CALCULATE([ADR], HotelOperations[Guest_Type] = \"Business\")", Description = "ADR for business guests", Folder = "Market Segmentation" },
    new { Name = "Leisure_Revenue_Pct", Expression = "DIVIDE([Leisure_Revenue], [Total_Revenue], 0)", Description = "Percentage of total revenue from leisure guests", Folder = "Market Segmentation" },
    new { Name = "Business_Revenue_Pct", Expression = "DIVIDE([Business_Revenue], [Total_Revenue], 0)", Description = "Percentage of total revenue from business guests", Folder = "Market Segmentation" },
    
    // Distribution Channel Metrics
    new { Name = "Direct_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Booking_Channel] = \"Direct\")", Description = "Total revenue from direct booking channel", Folder = "Distribution Channels" },
    new { Name = "OTA_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Booking_Channel] = \"OTA\")", Description = "Total revenue from OTA booking channel", Folder = "Distribution Channels" },
    new { Name = "Direct_Bookings", Expression = "CALCULATE(SUM(HotelOperations[Bookings]), HotelOperations[Booking_Channel] = \"Direct\")", Description = "Number of bookings from direct channel", Folder = "Distribution Channels" },
    new { Name = "OTA_Bookings", Expression = "CALCULATE(SUM(HotelOperations[Bookings]), HotelOperations[Booking_Channel] = \"OTA\")", Description = "Number of bookings from OTA channel", Folder = "Distribution Channels" },
    new { Name = "Direct_ADR", Expression = "CALCULATE([ADR], HotelOperations[Booking_Channel] = \"Direct\")", Description = "ADR for direct bookings", Folder = "Distribution Channels" },
    new { Name = "OTA_ADR", Expression = "CALCULATE([ADR], HotelOperations[Booking_Channel] = \"OTA\")", Description = "ADR for OTA bookings", Folder = "Distribution Channels" },
    new { Name = "Direct_Revenue_Pct", Expression = "DIVIDE([Direct_Revenue], [Total_Revenue], 0)", Description = "Percentage of total revenue from direct bookings", Folder = "Distribution Channels" },
    new { Name = "OTA_Revenue_Pct", Expression = "DIVIDE([OTA_Revenue], [Total_Revenue], 0)", Description = "Percentage of total revenue from OTA bookings", Folder = "Distribution Channels" },
    
    // Profitability Metrics
    new { Name = "Total_Profit", Expression = "SUM(HotelOperations[Profit])", Description = "Total profit", Folder = "Profitability Metrics" },
    new { Name = "Profit_Margin", Expression = "DIVIDE([Total_Profit], [Total_Revenue], 0)", Description = "Profit margin (profit as percentage of revenue)", Folder = "Profitability Metrics" },
    new { Name = "Total_Costs", Expression = "SUM(HotelOperations[Total_Costs])", Description = "Total costs", Folder = "Profitability Metrics" },
    new { Name = "Cost_Per_Room", Expression = "DIVIDE([Total_Costs], SUM(HotelOperations[Occupied_Rooms]), 0)", Description = "Average cost per occupied room", Folder = "Profitability Metrics" },
    new { Name = "Marketing_Efficiency", Expression = "DIVIDE([Total_Revenue], SUM(HotelOperations[Marketing_Spend]), 0)", Description = "Revenue generated per dollar of marketing spend", Folder = "Profitability Metrics" },
    new { Name = "Profit_Per_Room", Expression = "DIVIDE([Total_Profit], SUM(HotelOperations[Occupied_Rooms]), 0)", Description = "Average profit per occupied room", Folder = "Profitability Metrics" },
    new { Name = "Profit_YOY_Change_Pct", Expression = "VAR CurrentProfit = [Total_Profit] VAR PrevYearProfit = CALCULATE([Total_Profit], DATEADD(DateDim[Date], -1, YEAR)) RETURN IF(PrevYearProfit = 0, BLANK(), DIVIDE(CurrentProfit - PrevYearProfit, PrevYearProfit))", Description = "Year-over-year change in profit (percentage)", Folder = "Profitability Metrics" },
    
    // Seasonal Analysis Metrics
    new { Name = "Winter_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Season] = \"Winter\")", Description = "Total revenue during Winter season", Folder = "Seasonal Analysis" },
    new { Name = "Spring_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Season] = \"Spring\")", Description = "Total revenue during Spring season", Folder = "Seasonal Analysis" },
    new { Name = "Summer_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Season] = \"Summer\")", Description = "Total revenue during Summer season", Folder = "Seasonal Analysis" },
    new { Name = "Fall_Revenue", Expression = "CALCULATE([Total_Revenue], HotelOperations[Season] = \"Fall\")", Description = "Total revenue during Fall season", Folder = "Seasonal Analysis" },
    new { Name = "Winter_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Season] = \"Winter\")", Description = "Average occupancy rate during Winter season", Folder = "Seasonal Analysis" },
    new { Name = "Spring_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Season] = \"Spring\")", Description = "Average occupancy rate during Spring season", Folder = "Seasonal Analysis" },
    new { Name = "Summer_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Season] = \"Summer\")", Description = "Average occupancy rate during Summer season", Folder = "Seasonal Analysis" },
    new { Name = "Fall_Occupancy", Expression = "CALCULATE([Occupancy_Rate], HotelOperations[Season] = \"Fall\")", Description = "Average occupancy rate during Fall season", Folder = "Seasonal Analysis" },
    new { Name = "Seasonal_Revenue_Variance", Expression = "VAR AvgRevenue = AVERAGE(HotelOperations[Total_Revenue]) VAR SeasonAvg = AVERAGEX(VALUES(HotelOperations[Season]), [Total_Revenue]) RETURN DIVIDE(SeasonAvg - AvgRevenue, AvgRevenue)", Description = "Seasonal variance in revenue compared to overall average", Folder = "Seasonal Analysis" },
    
    // Customer Satisfaction Metrics
    new { Name = "Avg_Review_Score", Expression = "AVERAGE(HotelOperations[Average_Review_Score])", Description = "Average customer review score", Folder = "Customer Satisfaction" },
    new { Name = "Total_Complaints", Expression = "SUM(HotelOperations[Complaints])", Description = "Total number of customer complaints", Folder = "Customer Satisfaction" },
    new { Name = "Total_Compliments", Expression = "SUM(HotelOperations[Compliment])", Description = "Total number of customer compliments", Folder = "Customer Satisfaction" },
    new { Name = "Complaints_Per_100_Bookings", Expression = "DIVIDE([Total_Complaints], SUM(HotelOperations[Bookings]), 0) * 100", Description = "Number of complaints per 100 bookings", Folder = "Customer Satisfaction" },
    new { Name = "Compliments_Per_100_Bookings", Expression = "DIVIDE([Total_Compliments], SUM(HotelOperations[Bookings]), 0) * 100", Description = "Number of compliments per 100 bookings", Folder = "Customer Satisfaction" },
    new { Name = "Satisfaction_Ratio", Expression = "DIVIDE([Total_Compliments], [Total_Complaints], [Total_Compliments])", Description = "Ratio of compliments to complaints", Folder = "Customer Satisfaction" },
    new { Name = "Review_Score_YOY_Change", Expression = "VAR CurrentScore = [Avg_Review_Score] VAR PrevYearScore = CALCULATE([Avg_Review_Score], DATEADD(DateDim[Date], -1, YEAR)) RETURN CurrentScore - PrevYearScore", Description = "Year-over-year change in average review score", Folder = "Customer Satisfaction" },
    
    // Time Intelligence Metrics
    new { Name = "Revenue_MTD", Expression = "TOTALMTD([Total_Revenue], DateDim[Date])", Description = "Month-to-date total revenue", Folder = "Time Intelligence" },
    new { Name = "Revenue_QTD", Expression = "TOTALQTD([Total_Revenue], DateDim[Date])", Description = "Quarter-to-date total revenue", Folder = "Time Intelligence" },
    new { Name = "Revenue_YTD", Expression = "TOTALYTD([Total_Revenue], DateDim[Date])", Description = "Year-to-date total revenue", Folder = "Time Intelligence" },
    new { Name = "Occupancy_MTD", Expression = "TOTALMTD([Occupancy_Rate], DateDim[Date])", Description = "Month-to-date average occupancy rate", Folder = "Time Intelligence" },
    new { Name = "Occupancy_QTD", Expression = "TOTALQTD([Occupancy_Rate], DateDim[Date])", Description = "Quarter-to-date average occupancy rate", Folder = "Time Intelligence" },
    new { Name = "Occupancy_YTD", Expression = "TOTALYTD([Occupancy_Rate], DateDim[Date])", Description = "Year-to-date average occupancy rate", Folder = "Time Intelligence" },
    new { Name = "ADR_MTD", Expression = "TOTALMTD([ADR], DateDim[Date])", Description = "Month-to-date average daily rate", Folder = "Time Intelligence" },
    new { Name = "ADR_QTD", Expression = "TOTALQTD([ADR], DateDim[Date])", Description = "Quarter-to-date average daily rate", Folder = "Time Intelligence" },
    new { Name = "ADR_YTD", Expression = "TOTALYTD([ADR], DateDim[Date])", Description = "Year-to-date average daily rate", Folder = "Time Intelligence" },
    
    // KPI Metrics
    new { Name = "Revenue_Target", Expression = "VAR AvgRevenue = AVERAGEX(VALUES(DateDim[Month]), [Total_Revenue]) RETURN AvgRevenue * 1.1", Description = "Target revenue (10% above average)", Folder = "KPI Metrics" },
    new { Name = "Occupancy_Target", Expression = "0.85", Description = "Target occupancy rate of 85%", Folder = "KPI Metrics" },
    new { Name = "ADR_Target", Expression = "VAR AvgADR = AVERAGEX(VALUES(DateDim[Month]), [ADR]) RETURN AvgADR * 1.05", Description = "Target ADR (5% above average)", Folder = "KPI Metrics" },
    new { Name = "Profit_Margin_Target", Expression = "0.25", Description = "Target profit margin of 25%", Folder = "KPI Metrics" },
    new { Name = "Review_Score_Target", Expression = "4.5", Description = "Target review score of 4.5", Folder = "KPI Metrics" },
    new { Name = "Revenue_vs_Target", Expression = "DIVIDE([Total_Revenue], [Revenue_Target], 0)", Description = "Actual revenue as percentage of target", Folder = "KPI Metrics" },
    new { Name = "Occupancy_vs_Target", Expression = "DIVIDE([Occupancy_Rate], [Occupancy_Target], 0)", Description = "Actual occupancy as percentage of target", Folder = "KPI Metrics" },
    new { Name = "ADR_vs_Target", Expression = "DIVIDE([ADR], [ADR_Target], 0)", Description = "Actual ADR as percentage of target", Folder = "KPI Metrics" }
};

// Verificar si la tabla de destino existe, si no, crearla
Table targetTable = null;
if (Model.Tables.Contains(targetTableName))
{
    targetTable = Model.Tables[targetTableName];
}
else
{
    Info("Creando tabla para medidas: " + targetTableName);
    targetTable = Model.AddTable(targetTableName);
}

int addedCount = 0;
int updatedCount = 0;
int errorCount = 0;

// Diccionario para seguir las carpetas creadas
var createdFolders = new Dictionary<string, bool>();

// Procesar cada medida en nuestra lista
foreach (var measureInfo in measures)
{
    try
    {
        string measureName = measureInfo.Name;
        string measureExpression = measureInfo.Expression;
        string measureDescription = measureInfo.Description;
        string folderPath = measureInfo.Folder;
        
        // Verificar si la medida ya existe
        if (targetTable.Measures.Contains(measureName))
        {
            // Actualizar la medida existente
            Measure existingMeasure = targetTable.Measures[measureName];
            existingMeasure.Expression = measureExpression;
            existingMeasure.Description = measureDescription;
            
            // Actualizar la carpeta si es necesario
            if (!string.IsNullOrEmpty(folderPath))
            {
                existingMeasure.DisplayFolder = folderPath;
            }
            
            updatedCount++;
            Info("Actualizada medida: " + measureName);
        }
        else
        {
            // Crear una nueva medida
            Measure newMeasure = targetTable.AddMeasure(
                name: measureName,
                expression: measureExpression
            );
            newMeasure.Description = measureDescription;
            
            // Asignar a la carpeta si se especifica
            if (!string.IsNullOrEmpty(folderPath))
            {
                newMeasure.DisplayFolder = folderPath;
                
                // Registrar la carpeta como creada
                if (!createdFolders.ContainsKey(folderPath))
                {
                    createdFolders[folderPath] = true;
                    Info("Creada carpeta: " + folderPath);
                }
            }
            
            addedCount++;
            Info("Añadida medida: " + measureName);
        }
    }
    catch (Exception ex)
    {
        Error("Error al procesar la medida " + measureInfo.Name + ": " + ex.Message);
        errorCount++;
    }
}

// Mostrar resumen
Info("Importación completada.");
Info("Medidas añadidas: " + addedCount);
Info("Medidas actualizadas: " + updatedCount);
Info("Carpetas creadas: " + createdFolders.Count);
Info("Errores encontrados: " + errorCount);

// Mostrar estructura de carpetas creada
Info("Estructura de carpetas:");
foreach (var folder in createdFolders.Keys)
{
    Info("- " + folder);
}
