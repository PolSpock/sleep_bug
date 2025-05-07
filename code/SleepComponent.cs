using Sandbox;

public sealed class SleepComponent : Component
{
	[RequireComponent, Property] BoxCollider BoxCollider { get; set; }
	[RequireComponent, Property] ModelRenderer ModelRenderer { get; set; }

	protected override void OnStart()
	{
		base.OnStart();

		BoxCollider.KeyframeBody.AutoSleep = true;
		BoxCollider.KeyframeBody.Sleeping = true;
	}

	protected override void OnUpdate()
	{
		Log.Info( GameObject.Name + " is Sleeping: " + BoxCollider.KeyframeBody.Sleeping );
	}
}
