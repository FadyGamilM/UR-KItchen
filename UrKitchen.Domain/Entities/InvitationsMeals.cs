namespace UrKitchen.Domain.Entities;
public class InvitationsMeals :Entity
{
   private InvitationsMeals(
      int mealId,
      int invitationId,
      Meal meal,
      DinnerInvitation invitation      
   )
   {
      this.MealId = mealId;
      this.InvitationId = invitationId;
      this.Meal = meal;
      this.Invitation = invitation;
   }

   public int MealId {get; private set;}
   public Meal Meal {get; private set;}
   public int InvitationId {get; private set;}
   public DinnerInvitation Invitation {get; private set;}

   public static InvitationsMeals Create(
      int mealId,
      int invitationId,
      Meal meal,
      DinnerInvitation invitation
   )
   {
      var invitationMeal = new InvitationsMeals(
         mealId, 
         invitationId,
         meal, 
         invitation
      );
      return invitationMeal;
   }
}