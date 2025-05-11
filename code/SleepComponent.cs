using Sandbox;

public class SleepComponent : Component
{
	[RequireComponent, Property] BoxCollider BoxCollider { get; set; }
	[RequireComponent, Property] ModelRenderer ModelRenderer { get; set; }

	protected override void OnUpdate()
	{
		Log.Info( "----- OnUpdate -----" );
		Log.Info( GameObject.Name + " is Sleeping: " + BoxCollider.KeyframeBody.Sleeping );
		Log.Info( "Velocity: " + BoxCollider.KeyframeBody.Velocity + " | AngularVelocity: " + BoxCollider.KeyframeBody.AngularVelocity );
	}
}
