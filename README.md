# Subhajit Ghosh Author Website

An ASP.NET Core Razor Pages website targeting .NET 8, with English and Bengali language options. The supplied author biography and portrait are included. The catalogue features The AI Circuit Breaker, Rotirokto, Troyee Rohoshyo, and Sher Afganer Tarabari, with confirmed purchase options and publisher details. Three forthcoming Bengali mystery titles and three forthcoming English AI/leadership titles are listed as provided. Further descriptions, testimonials, messaging delivery, and newsletter services remain pending.

## Requirements

- .NET 8 SDK

## Run locally

From this directory:

```powershell
dotnet run --urls http://localhost:5173
```

Open `http://localhost:5173` in a browser. Use the `EN` / `বাংলা` control in the header to change languages; the selection is retained in browser local storage.

## Verify

```powershell
dotnet build .\AuthorWebsite.csproj
```

## Current behavior

- Home page presents the author biography in English and Bengali, plus a reserved section for approved testimonials.
- Books page provides working category filters, four confirmed published titles, direct Amazon links where supplied, a phone purchase option for Sher Afganer Tarabari, and a placeholder for unconfirmed leadership details.
- FAQ finder runs locally in the browser and answers only from confirmed site information. It does not call an AI provider or send questions to a server; it acknowledges unknown book-specific details.
- Contact links open the visitor's email client to compose a message to the author; the site does not collect or store messages. Newsletter signup is not connected.
- Bengali UI text is included; book content translations should be reviewed before publication.

## Content to add before launch

Provide remaining approved book descriptions, publication status/dates, cover assets and usage rights, verified publisher/retailer URLs, and permissioned testimonials. The supplied author portrait is stored at `wwwroot/images/Subhajit_LinkedIn_Image.png`; book covers are stored in `wwwroot/images/`. The confirmed AI book product page is `https://www.amazon.com/dp/B0GZCVB17F`. Choose a secure message destination/reply owner and newsletter provider before enabling those services. Update the FAQ responses only from author-approved information.

Project-wide directions and the benchmark proposal are in [a.md](a.md).
