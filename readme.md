# Hotel Revenue Management Analytics using Power Bi for visualization

A comprehensive Power BI solution for hotel revenue management, offering detailed analysis of pricing, occupancy, market segmentation, and profitability.Today

## Repository Structure

```
📂 hotel-revenue-analytics/
│
├── 📂 assets/
│   ├── 📂 images/
│   │   ├── 📄 hotel-dashboard-banner.jpg
│   │   ├── 📄 dashboard-preview.gif
│   │   ├── 📄 executive-summary.jpg
│   │   ├── 📄 revenue-analysis.jpg
│   │   ├── 📄 pricing-occupancy.jpg
│   │   ├── 📄 market-segmentation.jpg
│   │   ├── 📄 channel-analysis.jpg
│   │   ├── 📄 profitability-analysis.jpg
│   │   ├── 📄 customer-satisfaction.jpg
│   │   ├── 📄 time-intelligence.jpg
│   │   ├── 📄 year-over-year.jpg
│   │   ├── 📄 marketing-performance.jpg
│   │   ├── 📄 kpi-tracking.jpg
│   │   ├── 📄 logo.jpg
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

## File Contents

### README.md

```markdown
# 🏨 Hotel Revenue Management Analytics Dashboard

![Dashboard Banner](assets/images/hotel-dashboard-banner.png)

[![Status](https://img.shields.io/badge/Status-Active-success)](https://github.com/yourusername/hotel-revenue-analytics)
[![Version](https://img.shields.io/badge/Version-1.0.0-blue)](https://github.com/yourusername/hotel-revenue-analytics/releases)
[![Power BI](https://img.shields.io/badge/Power%20BI-Latest-F2C811)](https://powerbi.microsoft.com/)
[![License](https://img.shields.io/badge/License-MIT-green)](LICENSE)

## 🚀 Overview

**Hotel Revenue Analytics** is a comprehensive business intelligence solution developed with Microsoft Power BI that transforms hotel operational data into actionable insights for revenue management. Designed for revenue managers, hotel directors, and commercial teams who need to optimize pricing, occupancy, and overall profitability in real-time.

![Main Dashboard](assets/images/dashboard-preview.gif)

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

## 🔍 Screenshots

### Executive Summary
![Executive Summary](assets/images/executive-summary.png)

### Revenue Analysis
![Revenue Analysis](assets/images/revenue-analysis.png)

### Pricing & Occupancy
![Pricing & Occupancy](assets/images/pricing-occupancy.png)

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

<p align="center">Developed with ❤️ by <a href="https://github.com/yourusername">Your Name</a></p>
```

### implementation-guide.md

```markdown
# Hotel Revenue Management Dashboard Implementation Guide

This guide provides detailed instructions for implementing the hotel revenue management analytics dashboard in your organization.

## Table of Contents
1. [Prerequisites](#prerequisites)
2. [Installation](#installation)
3. [Connecting to Data Sources](#connecting-to-data-sources)
4. [Dashboard Customization](#dashboard-customization)
5. [Setting Up Refreshes](#setting-up-refreshes)
6. [Sharing and Publishing](#sharing-and-publishing)
7. [Troubleshooting](#troubleshooting)

## Prerequisites

Before beginning implementation, ensure you have:

- Microsoft Power BI Desktop (version 2.112.x or later)
- Appropriate permissions to access hotel operational data
- Basic knowledge of Power BI
- Microsoft Power BI Pro or Premium (for sharing and publishing)
- Hotel operational data in CSV format or compatible PMS system

## Installation

1. **Clone or download the repository**
   ```
   git clone https://github.com/yourusername/hotel-revenue-analytics.git
   ```

2. **Access the project folder**
   ```
   cd hotel-revenue-analytics
   ```

3. **Open the main PBIX file**
   - Navigate to the `dashboards/` folder
   - Open the `hotel-revenue-dashboard.pbix` file with Power BI Desktop

## Connecting to Data Sources

The dashboard can connect to different data sources. Follow these steps to configure your connection:

### Option 1: Use the included sample data

1. This option is preconfigured and uses the data in `assets/sample-data/hotel_data_sample.csv`
2. Ideal for evaluation and testing of the dashboard

### Option 2: Connect to your custom CSV

1. In Power BI Desktop, go to **Home > Transform data**
2. Select the "Hotel Operations" query (main data source)
3. Click on **Source** in the Power Query editor
4. Update the file path to point to your custom CSV
5. Click **Close & Apply**

### Option 3: Connect to your PMS system or database

1. In Power BI Desktop, go to **Home > Transform data**
2. Select the "Hotel Operations" query
3. Click on **Source** in the Power Query editor
4. Select **New source** and choose the appropriate connection type (SQL Server, Oracle, etc.)
5. Configure the connection parameters (server, database, credentials)
6. Write your custom SQL query or select the necessary tables
7. Adapt transformations as needed
8. Click **Close & Apply**

## Dashboard Customization

### Visual Customization

1. **Change corporate colors**
   - Go to **View > Theme**
   - Select an existing theme or create a new one that matches your brand
   - For creating a custom theme, refer to `docs/theme-customization.md`

2. **Modify logos**
   - Click on the existing logo images
   - Select **Home > Image**
   - Browse and select your own logo

3. **Adjust KPIs and metrics**
   - Right-click on any visualization
   - Select **Edit visualization**
   - Modify fields and filters according to your needs

### Advanced Customization

1. **Modify DAX measures**
   - Go to **Modeling > New measure**
   - Create or modify measures according to your specific needs
   - Refer to `docs/dax-measures.md` for complete documentation of measures

2. **Adjust data relationships**
   - Go to the **Model** view
   - Review and modify relationships between tables as needed

3. **Create new dashboard pages**
   - Click on the + icon at the bottom
   - Design new pages according to your needs
   - Refer to `docs/dashboard-design.md` for best practices

## Setting Up Refreshes

### Local Refresh

1. Configure scheduled refresh in Power BI Desktop:
   - **File > Options and settings > Options**
   - Configure refresh frequency according to your needs

### Power BI Service Refresh

1. Publish the report to Power BI Service
2. Set up the on-premises data gateway if your data is in internal systems
3. Configure the refresh schedule:
   - Go to the dataset
   - Select **Schedule refresh**
   - Configure refresh frequency and time

## Sharing and Publishing

### Publish to Power BI Service

1. In Power BI Desktop, click on **Home > Publish**
2. Sign in to your Power BI account
3. Select the destination workspace
4. Click **Publish**

### Share with Your Team

1. In Power BI Service, go to the published report
2. Click on **Share**
3. Add the emails of people you want to share with
4. Configure appropriate permissions
5. Click **Share**

### Create an App

1. In Power BI Service, go to the workspace
2. Click on **Create app**
3. Configure app details (name, description, image)
4. Select content to include
5. Configure access and navigation
6. Publish the app

## Troubleshooting

### Common Issues and Solutions

1. **Data connection error**
   - Verify data source credentials
   - Confirm file path is correct
   - Verify access permissions

2. **Slow performance**
   - Optimize queries using the Power Query editor
   - Reduce data volume using appropriate filters
   - Simplify complex DAX measures
   - Refer to `docs/performance-optimization.md`

3. **Calculation discrepancies**
   - Verify DAX formulas in `docs/dax-measures.md`
   - Confirm context filters are working correctly
   - Verify data granularity

### Additional Support

If you encounter issues not covered in this guide:

1. Refer to the complete documentation in the `docs/` folder
2. Open an issue in the GitHub repository
3. Contact the support team at [youremail@example.com](mailto:youremail@example.com)

## Next Steps

Once you've implemented the dashboard, we recommend:

1. Review the analysis guide in `docs/analysis-guide.md`
2. Familiarize yourself with all metrics in `docs/metrics-dictionary.md`
3. Train your team on dashboard usage
4. Establish regular meetings to analyze the insights obtained
5. Implement data-driven strategies to optimize revenue
```
