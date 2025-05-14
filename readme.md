# Hotel Revenue Management Analytics using Power BI for visualization

A comprehensive Power BI solution for hotel revenue management, offering detailed analysis of pricing, occupancy, market segmentation, and profitability.

## Repository Structure

```
📂 PBI-hotel-revenue-analytics/
│
├── 📂 Asset/
│   ├── 📂 Images/
│   │   ├── 📄 0_Menu_2025-04-23 123745.jpg
│   │   ├── 📄 1_Executive_Summary_2025-04-23 123841.jpg
│   │   ├── 📄 1.2Executive_Report_2025-04-23 123921.jpg
│   │   ├── 📄 1.3_Other Executive_2025-04-23 123921.jpg
│   │   ├── 📄 2.Revenue_Analysis_2025-04-23 124051.jpg
│   │   ├── 📄 2.1_Other_Revenue_2025-04-23 124325.jpg
│   │   ├── 📄 3_Pricing_and_Occupancy_2025-04-23 124406.jpg
│   │   ├── 📄 4_market_segmentation_2025-04-23 124453.jpg
│   │   ├── 📄 5_Channel_Performance_2025-04-23 124533.jpg
│   │   ├── 📄 6_Profitability_Analysis_2025-04-23 124634.jpg
│   │   ├── 📄 7_Customer_Satisfaction_2025-04-23 124730.jpg
│   │   ├── 📄 8_Marketing_Performance_2025-04-23 124808.jpg
│   │   ├── 📄 9_Kpi_Tracking_2025-04-23 124844.jpg
│   │   ├── 📄 icons/
│   │   └── 📄 screenshots/
│   │
│   └── 📂 sample-data/
│       └── 📄 hotel_data_sample.csv
│
├── 📂 dashboards/
│   ├── 📄 hotel-revenue-dashboard.pbix
│   ├── 📄 executive-summary.pdf
│   └── 📄 sample-reports.pdf
│
├── 📂 docs/
│   ├── 📄 implementation-guide.md
│   ├── 📄 metrics-dictionary.md
│   ├── 📄 analysis-guide.md
│   ├── 📄 dax-measures.md
│   ├── 📄 power-query-transformations.md
│   ├── 📄 visualization-specifications.md
│   ├── 📄 hotel-revenue-management-report.md
│   └── 📄 performance-optimization.md
│
├── 📂 scripts/
│   ├── 📄 power-query-transformations.pq
│   └── 📄 tabular-editor-script.csx
│
├── 📄 LICENSE
├── 📄 README.md
└── 📄 CONTRIBUTING.md
```

# 🏨 Hotel Revenue Management Analytics Dashboard

![Dashboard Banner](Asset/Images/0_Menu_2025-04-23%20123745.jpg)

[![Status](https://img.shields.io/badge/Status-Active-success)](https://github.com/yourusername/hotel-revenue-analytics)
[![Version](https://img.shields.io/badge/Version-1.0.0-blue)](https://github.com/yourusername/hotel-revenue-analytics/releases)
[![Power BI](https://img.shields.io/badge/Power%20BI-Latest-F2C811)](https://powerbi.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

## 🚀 Overview

**Hotel Revenue Analytics** is a comprehensive business intelligence solution developed with Microsoft Power BI that transforms hotel operational data into actionable insights for revenue management. Designed for revenue managers, hotel directors, and commercial teams who need to optimize pricing, occupancy, and overall profitability in real-time.

![Main Dashboard](Asset/Images/0_Menu_2025-04-23%20123745.jpg)

## ✨ Key Features

- **Comprehensive Revenue Analysis**: Trends, seasonality, and behavior patterns by season and day of week
- **Price Optimization (ADR)**: Analysis of the relationship between price and occupancy to maximize revenue
- **Market Segmentation**: Breakdown by guest type (Business vs. Leisure) and country of origin
- **Distribution Channel Analysis**: Comparison between direct bookings and OTAs
- **Profitability Measurement**: Analysis of margins, marketing efficiency, and cost structure
- **Customer Satisfaction**: Correlation between review scores and revenue

## 📊 Included Dashboards

| Dashboard | Description |
|-----------|-------------|
| **Executive Summary** | Overview of key KPIs and main metrics |
| **Revenue Analysis** | Detailed revenue breakdowns by month, season, and day of week |
| **Pricing & Occupancy** | Analysis of the relationship between ADR and occupancy rate |
| **Market Segmentation** | Performance by guest type and country of origin |
| **Distribution Channels** | Comparison between booking channels |
| **Profitability Analysis** | Profit margins and cost structure |
| **Customer Satisfaction** | Correlation between satisfaction and revenue |
| **Time Intelligence** | MTD/QTD/YTD performance metrics and comparisons |
| **Year-over-Year Analysis** | Comparative performance analysis with previous periods |
| **Marketing Performance** | Marketing efficiency and ROI analysis |
| **KPI Tracking** | Performance visualization against targets |

## 📋 Requirements

- Power BI Desktop (version 2.112.x or later)
- Hotel operations dataset (included as sample or connect to your own source)
- Basic knowledge of Power BI for customization

## 🔧 Installation and Usage

1. Clone this repository
```
git clone https://github.com/yourusername/hotel-revenue-analytics.git
```

2. Open the main PBIX file in Power BI Desktop
```
hotel-revenue-dashboard.pbix
```

3. Connect to your own data sources or use the included sample data

4. Customize according to your property's specific needs

For detailed instructions, refer to our [implementation guide](docs/implementation-guide.md).

## 📈 Key KPIs Analyzed

- **RevPAR** (Revenue Per Available Room)
- **ADR** (Average Daily Rate)
- **Occupancy Rate**
- **TRevPAR** (Total Revenue Per Available Room)
- **GOPPAR** (Gross Operating Profit Per Available Room)
- **Marketing Efficiency**: Revenue to marketing spend ratio
- **Customer Satisfaction**: Review scores and their impact on revenue

## 🔍 Dashboard Screenshots

### 0. Dashboard Menu
![Dashboard Menu](Asset/Images/0_Menu_2025-04-23%20123745.jpg)

### 1. Executive Summary
![Executive Summary](Asset/Images/1_Executive_Summary_2025-04-23%20123841.jpg)

### 1.2 Executive Report
![Executive Report](Asset/Images/1.2Executive_Report_2025-04-23%20123921.jpg)

### 1.3 Other Executive
![Other Executive](Asset/Images/1.3_Other%20Executive_2025-04-23%20123921.jpg)

### 2. Revenue Analysis
![Revenue Analysis](Asset/Images/2.Revenue_Analysis_2025-04-23%20124051.jpg)

### 2.1 Other Revenue
![Other Revenue](Asset/Images/2.1_Other_Revenue_2025-04-23%20124325.jpg)

### 3. Pricing and Occupancy
![Pricing and Occupancy](Asset/Images/3_Pricing_and_Occupancy_2025-04-23%20124406.jpg)

### 4. Market Segmentation
![Market Segmentation](Asset/Images/4_market_segmentation_2025-04-23%20124453.jpg)

### 5. Channel Performance
![Channel Performance](Asset/Images/5_Channel_Performance_2025-04-23%20124533.jpg)

### 6. Profitability Analysis
![Profitability Analysis](Asset/Images/6_Profitability_Analysis_2025-04-23%20124634.jpg)

### 7. Customer Satisfaction
![Customer Satisfaction](Asset/Images/7_Customer_Satisfaction_2025-04-23%20124730.jpg)

### 8. Marketing Performance
![Marketing Performance](Asset/Images/8_Marketing_Performance_2025-04-23%20124808.jpg)

### 9. KPI Tracking
![KPI Tracking](Asset/Images/9_Kpi_Tracking_2025-04-23%20124844.jpg)

## 🔍 Screenshots

### Executive Summary
![Executive Summary](Asset/Images/1_Executive_Summary_2025-04-23%20123841.jpg)

### Revenue Analysis
![Revenue Analysis](Asset/Images/2.Revenue_Analysis_2025-04-23%20124051.jpg)

### Pricing & Occupancy
![Pricing and Occupancy](Asset/Images/3_Pricing_and_Occupancy_2025-04-23%20124406.jpg)

## 💡 Key Insights

The data analysis reveals important patterns that can drive strategic decisions:

- Strong positive correlation (0.98) between ADR and Occupancy Rate, suggesting opportunities for strategic price adjustments without significantly impacting occupancy
- Leisure guests generate the highest revenue, with visitors from the USA contributing most to overall revenue
- Direct booking channel produces the highest revenue, while the OTA channel commands a higher ADR
- Fridays consistently generate the highest daily revenue, while Thursdays show the lowest performance
- Strong correlation (0.89) between review scores and revenue, highlighting the importance of guest experience

## 🤝 Contributions

Contributions are welcome! If you'd like to improve this project:

1. Fork the repository
2. Create a branch for your feature (`git checkout -b feature/new-feature`)
3. Commit your changes (`git commit -m 'Add new feature'`)
4. Push to the branch (`git push origin feature/new-feature`)
5. Open a Pull Request

## 📚 Additional Documentation

- [Implementation Guide](docs/implementation-guide.md)
- [Metrics Dictionary](docs/metrics-dictionary.md)
- [Analysis Guide](docs/analysis-guide.md)
- [DAX Measures](docs/dax-measures.md)
- [Visualization Specifications](docs/visualization-specifications.md)
- [Power Query Transformations](docs/power-query-transformations.md)

## 📞 Support and Contact

Questions, issues, or suggestions? [Open an issue](https://github.com/yourusername/hotel-revenue-analytics/issues) or contact us at [youremail@example.com](mailto:youremail@example.com).

## 📄 License

This project is under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Developed with ❤️ by [Your Name](https://github.com/yourusername)
