Our server planning could go one of two ways:

- A large server which encompasses all the operations of the webpage, including emits from Edge and Podium.
- A small server which works in tandem with Podium, Edge, Shopify, and Google.

Ideal would be the former, which would handle more seamlessly the operations of the page, with fewer requests passed between servers.

For the meantime, development of localized tools makes more sense:

<!-- NOTE The calendar integration would be a scheduling widget that prevents bookings during filled slots and which sync with the Portsches @gmail account. -->
<!-- Google handles much of the appointmnet scheduling. For example, when booking a flight or a ticket for eventBrite, google adds it automatically to your calendar. Therefore, all we need is to assosciate the Portsche's email in every request. -->
[] Google Calendar integrated plugin

<!-- NOTE Models for jewelry should reflect their data structure in the Edge Invetory system to allow for future scaling -->
[] jewelry models - handled by Edge?

- [] Categories (array[str]), Name(int), price retail (dec), price current (dec), store location (int; mapped to front-end key), inStock (bool), quantity (int), vendorID (str), SKU (str), image(s) (str), notes? (str), tags (array[str])
