# Author Website: Project Directions and Proposal

**Status:** Approved direction; implementation is underway with ASP.NET Core Razor Pages on .NET 8.

## 1. Purpose

Create a polished official website for Subhajit Ghosh that helps readers:

- Discover AI, leadership, thriller, and horror books.
- Understand what each book is about and where to buy it.
- Find reliable information about upcoming books and author news.
- Contact the author and receive a reply through a clear, privacy-conscious process.
- Ask questions about books through an optional AI chatbot grounded in approved book information.

The site should feel like an author’s home on the web, not a generic publisher template. It should make the books easy to browse while giving the author a credible, personal voice.

## 2. Benchmark Review

This is a focused comparison of six prominent authors’ official websites, not a claim that every successful author site worldwide was reviewed. The review considered book discovery, new/upcoming work, author information, reader updates, and interaction patterns. Site content changes over time; references below were reviewed on 29 October 2026.

| Official site | Observed strengths | Useful lesson | What not to copy blindly |
|---|---|---|---|
| [Brandon Sanderson](https://www.brandonsanderson.com/) | Strong series/world navigation, prominent shop and newsletter paths, progress updates and news. | Give readers both a simple “start here” path and deeper ways to explore series or categories. | A highly elaborate fictional-universe structure would be excessive unless Subhajit’s books need it. |
| [James Patterson](https://www.jamespatterson.com/) | Homepage surfaces new releases and coming soon titles, with a large catalog and clear newsletter, event, and about links. | Keep current and upcoming books visible and make purchase actions direct. | A very large catalog layout can overwhelm a smaller, cross-genre bibliography. |
| [Stephen King](https://www.stephenking.com/) | Detailed release and upcoming listings, direct retailer/preorder links, news, newsletter, works index, and FAQ/contact. | Treat upcoming titles as useful, maintained book records, not vague teaser cards. | Avoid long, dense homepage listings that bury the author’s identity and the main next action. |
| [George R. R. Martin](https://www.georgerrmartin.com/) | Clear Books, About, News, and fan-oriented sections; visible appearances and blog/news updates. | A small number of durable navigation choices can serve many reader needs. | Separate fan/community destinations only when there is enough ongoing content to maintain them. |
| [J.K. Rowling](https://www.jkrowling.com/) | Books grouped by readership/series, clear news, author material, FAQs, media and enquiry information. | Group a varied body of work into understandable reading paths, and make professional enquiries distinct from reader messages. | Multiple branded sub-sites and complex corporate/legal content may be unnecessary at launch. |
| [Neil Gaiman](https://www.neilgaiman.com/) | Personal voice, journal, new-release and coming-soon information, and a visible feedback route. | A recognizable author voice can make even a compact site feel personal and current. | A journal is only valuable if it can be maintained consistently. |

### Shared patterns worth adopting

1. Books are the central navigation object: readers should quickly find titles, series/categories, formats, and buy links.
2. New and upcoming work gets explicit status and timing, rather than being mixed ambiguously with available books.
3. About/news/contact information is easy to reach without turning every topic into a top-level page.
4. Newsletter signup remains a dependable reader-update channel even when social platforms change.
5. The strongest sites reflect the author’s specific body of work; their common structure is useful, but their brand designs are not interchangeable.

## 3. Proposal

### Positioning and visual direction

Build an editorial, literary identity that can hold both nonfiction (AI and leadership) and fiction (thriller and horror). Use a confident author portrait, considered typography, strong book-cover imagery, restrained motion, and a distinct visual treatment for each genre category. Keep the overall site coherent; let book art and category accents supply tonal variation.

Avoid generic “tech startup” imagery for AI books and generic horror clichés. Use authentic book covers and approved author photography when supplied. Until then, clearly mark artwork and book details as placeholders; do not invent publication facts, endorsements, retailer links, or biography claims.

### Recommended compact structure

Use two principal pages, with useful sections and optional book-detail URLs:

1. **Home (`/`)**
   - Author identity and concise introduction.
   - Featured books across the different writing areas.
   - A visible “Explore the books” action.
   - Upcoming book highlight when real information is available.
   - Short author-story section.
   - Newsletter signup and a discreet contact/chat entry point.
2. **Books (`/books`)**
   - Filters or tabs for AI, Leadership, Thriller, and Horror.
   - Available, forthcoming, and in-progress statuses clearly distinguished.
   - Book cards with cover, title, short description, format/status, and verified retailer links.
   - Optional detail route for each title if the catalog needs longer descriptions, excerpts, FAQs, or multiple retailer links.
3. **Contact and reader conversation** can begin as a section on Home or Books rather than a third full page. Give it a dedicated route later if message volume or chatbot use warrants it.

Keep the About/story section on Home initially. This keeps navigation compact while still allowing readers to learn who Subhajit is.

### Book information model

For each title, collect and confirm:

- Exact title and subtitle.
- Category/genre and any series or reading order.
- Cover image and image-use rights.
- Description, audience, and optional excerpt.
- Publication status and date, if publicly announceable.
- Formats, ISBNs if applicable, and verified retailer/publisher purchase URLs by region.
- Whether the title is available, preorderable, forthcoming, or only a concept under development.

A book’s “buy” action should link to a retailer or publisher; the site should not imply it processes sales unless ecommerce is deliberately added later.

## 4. Reader Contact and Replies

A contact form should collect only what is needed: name (optional), email for reply, message, and consent to be contacted. Include spam protection, rate limits, privacy notice, and a confirmation that submission does not guarantee an immediate response.

Messages need a secure destination and a human response workflow. A practical first release is a protected provider mailbox/helpdesk workflow with notifications and a documented owner, rather than building a custom inbox/admin portal before message volume is known. Do not expose submitted messages publicly. Avoid storing sensitive personal information and define deletion/retention rules before launch.

A public discussion board is not recommended for the first release: it requires moderation, abuse handling, and ongoing community management. Begin with private messages and, if useful, moderated reader Q&A or events later.

## 5. Book Chatbot

The chatbot is feasible, but should be a separate planned capability rather than a decorative widget that guesses.

### Recommended behavior

- Answer only from approved book metadata, descriptions, excerpts, FAQs, and author-provided material.
- Say when it does not know; link to the relevant title or contact form.
- Provide “where can I buy this?” answers using only verified retailer links.
- Clearly identify itself as an AI assistant, not Subhajit.
- Do not claim to represent the author’s personal views or promise a personal reply.
- Do not expose private reader messages to the bot or use them as training data by default.

### Planning decisions before implementation

- Which hosting/model provider and budget limits are acceptable?
- Which exact content may be indexed and sent to that provider?
- Whether chat is anonymous, rate-limited, or requires email for follow-up.
- What is logged, for how long, and how users can request deletion.
- How to prevent prompt injection and unsupported claims; the bot must treat retrieved site content as information, not instructions.
- A human fallback and maintenance owner for corrections.

Start with a searchable FAQ or scripted book finder if no backend/model provider is selected. This provides useful reader help without inventing a live AI integration.

## 6. Suggested Delivery Phases

1. **Content and rights inventory:** collect actual books, covers, descriptions, author bio/headshot, dates, and purchase links; label unconfirmed items.
2. **Experience definition:** confirm audience, brand direction, navigation, contact workflow, newsletter provider, and chatbot boundaries.
3. **Website MVP:** responsive Home and Books pages, accessible navigation, real book records, verified external buy links, contact form connected to a chosen secure destination, and newsletter form connected to a chosen provider.
4. **Chat assistant:** only after approved source content, provider, privacy terms, cost, and human fallback are agreed.
5. **Launch readiness:** accessibility, mobile/browser checks, SEO metadata, analytics consent/privacy decision, security review, content review, backups, domain/hosting, and a named person responsible for updates.

## 9. Approved Implementation Direction

- Framework: ASP.NET Core Razor Pages on .NET 8. The .NET 8 SDK and ASP.NET Core runtime are available in the implementation environment.
- Languages: English and Bengali, with a persistent language switch and localized page labels and accessibility metadata. Book translations should be reviewed before publication.
- Bengali rendering of the author's name: **শুভজিৎ ঘোষ**. Keep the approved Latin-script form, **Subhajit Ghosh**, in English.
- Chatbot: a book FAQ finder grounded only in author-approved content. Until approved FAQs and a service provider exist, the first build will provide a clearly labeled FAQ-finder interface using curated local content, not a fabricated live AI integration.
- Pending content: further book covers/descriptions/purchase links and author photos will be supplied later. The author has supplied approved English and Bengali biographies and a set of forthcoming titles; these are now represented in the site. Use explicit development placeholders for remaining unknown details; do not invent facts or link destinations.
- Testimonials: reserve a section in the layout, but show no fabricated endorsements. Publish only quotes approved for public use.
- Confirmed AI title: **The AI Circuit Breaker: The Executive Leadership Framework for Governing CoPilots, Agents, and High-Stakes Decisions**. Amazon lists author Subhajit Ghosh, publication date May 2, 2026, Kindle edition, and a 230-page print replica. Direct product page: https://www.amazon.com/dp/B0GZCVB17F. Cover source: Amazon product image, stored locally at `wwwroot/images/the-ai-circuit-breaker.jpg` for the site card.
- Pending services: the author email link is `sgresearch@authorrepo.com`; no website-hosted contact form or newsletter provider is connected. Do not imply that a disconnected form sends messages or subscriptions.

## 7. Items to Confirm Before Building

1. Is the public author name exactly **Subhajit Ghosh**, and should the site be English-only or include Bengali?
2. Which real titles belong in each category, and which are published, upcoming, or still in development?
3. What are the official cover images and retailer/publisher buy links? Are regional storefronts needed?
4. What author portrait, biography, and contact email may be published?
5. Where should reader messages go, who replies, and what response-time expectation should be stated?
6. Which newsletter service is preferred, or should signup wait until one is selected?
7. Should the first chatbot release be a grounded FAQ/book finder, or is a specific AI provider already approved?
8. Is there an existing domain, logo, or visual identity to preserve?

## 8. Source Notes

The comparison is based on publicly visible pages from the authors’ official sites:

- Brandon Sanderson: https://www.brandonsanderson.com/
- James Patterson: https://www.jamespatterson.com/
- Stephen King: https://www.stephenking.com/
- George R. R. Martin: https://www.georgerrmartin.com/
- J.K. Rowling: https://www.jkrowling.com/
- Neil Gaiman: https://www.neilgaiman.com/

These are examples, not a comprehensive global ranking. The recommendations above abstract common information-design patterns; they do not propose copying any author’s text, imagery, branding, or site implementation.
