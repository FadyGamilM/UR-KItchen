# UR-Kitchen
UR-Kitchen is a dinner hosting platform that allow users to make dinners for each other based on others requests, and also users can announce a dinner invitation and others can sign to this invitations, so its basically a platform for offering a service and also for knowing new people.

# Initial Presentation Layer Design:
![](UI.png)

# API Endpoints Design:
- `GET   api/home`
```json
{
  "OfferedMeals" : [
      {
        "Name" : "bla bla bla",
        "ServingSize" : 5,
        "Owner" : "Fady Gamil",
        ""
        "PreparingTime" : "3",
        "DeliveryAvailable" : true,
        "CreatedAt" : "Fri, 16 May 2015 05:50:06 GMT",
      },
      {
        .....
      },
  ],
    
  "DinnerInvitations" : [
      {
        "Menu" : [
            {
              "Meal" : "roast",
              "ServingSize" : "3",
              "SideDishes" : [
                  {
                     "Name" : "Baked beans",
                     "ServingSize" : "5"
                  }
              ]
            },
            {...}
         ],
        "DinnerTime" : "09:00 PM",
        "HostId" : "7b28847a-b6e3-4159-86a0-14b3d642301b",
        "HostName" : "Fady Gamil",
        "AvailableSeats" : 5,
        "SignedGuests": [
            {
              "GuestId" : "u423954f-ysxa-4159-89a0-14b3d642301b",
              "GuestName" : "Ahmed Mostafa",
            },
            {...}
        ]
      },
      {
        .....
      },
    ],
}
```
