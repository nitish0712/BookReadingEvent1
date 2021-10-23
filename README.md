# Book Reading Application

It was a .Net web application using the MVC framework. The application was designed to manage book-reading events, where book lovers come together for a community reading of their favorite book. Users can register on the website to create their own events and can invite other members to their events via email. The application was backed up by several validations for logged-in and anonymous users at both server and client-side along with unit test cases for each controller. Additionally, an admin was added in the application to monitor the activities of each user, where he can delete or edit any event.

High level specifications for the application are as below:

Home page o Displays all public events as hyperlinks. There should be 2 columns, one for past events and one for future events. o Clicking hyperlink takes user to event details page. o Logged in users see additional header items: “My events”, “Events invited to”, “Create event”

THIS IS THE LANDING HOME PAGE

<img width="671" alt="BookReading_HomePage" src="https://user-images.githubusercontent.com/86431283/138565172-4f897650-39c5-4d4c-8d23-8c056ae0b775.PNG">

THIS IS HOME PAGE FOR LOGGED IN USERS

<img width="678" alt="LoggedIn_HomePage" src="https://user-images.githubusercontent.com/86431283/138565216-48fb9f7f-7197-4d7a-9788-434a3cf1f706.PNG">



A book reading event has o Title of the book, date of the event, location and start time. o Optionally, the event organizer may also specify the duration, description and other details.
The event can be marked as public or private.
The event creator can add people to the event by specifying their email. Multiple people can be invited by specifying multiple, comma-separated emails.
Users can register on the website to create their own events.
Anonymous users can only view public events
“Events invited to” (visible to logged in users) will list all events as hyperlinks where the current logged in user was invited to (by matching email). Even private events are shown here if the user was invited. Hyperlinks redirect to event details page.

EVENT DESCRIPTION

<img width="686" alt="AboutEvent" src="https://user-images.githubusercontent.com/86431283/138565242-7b7ae4ac-2eae-43d0-9e82-aa19dc97bae7.PNG">


“My events” (visible to logged in users) shows all events created by user, sorted by newest event-start-date first. There should be an “Edit” link in front of each entry which allow to edit the event. o User can edit only the events that (s)he created!
Create a user with a specific hard-coded email, for example “myadmin@bookevents.com”. This user will be treated as an administrator for the system (will have admin role). o Admin user can edit ANY event o The list of events will show ALL events for him, whether public/private
Add a special url called “/customer-support” that simply redirects to helpdesk.nagarro.com

CREATE EVENT

<img width="713" alt="CreateEventPage" src="https://user-images.githubusercontent.com/86431283/138565251-8d0f8a4a-dacb-471b-9462-b9a0743ac213.PNG">


SIGNUP PAGE 

<img width="667" alt="BookReading_SignUp" src="https://user-images.githubusercontent.com/86431283/138565256-717ddb5e-4e67-48fd-adc3-de2053c84969.PNG">

SIGNIN PAGE 

<img width="675" alt="BookReading_SignIn" src="https://user-images.githubusercontent.com/86431283/138565259-94582ce0-a50b-4848-82d9-95f6e391f0be.PNG">

Technical considerations:

Validated at both server and client side

Used [Authenticate] and [Authorize] attributes for authentication and authorization

Created a 3-layer solution

Added interceptor and log all DB commands to console
