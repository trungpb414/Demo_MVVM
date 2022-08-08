package crc645cf6a19fc344993c;


public class CustomRoundButton
	extends crc643f46942d9dd1fff9.ButtonRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Demo_MVVM.Droid.CustomRoundButton, Demo_MVVM.Android", CustomRoundButton.class, __md_methods);
	}


	public CustomRoundButton (android.content.Context p0)
	{
		super (p0);
		if (getClass () == CustomRoundButton.class)
			mono.android.TypeManager.Activate ("Demo_MVVM.Droid.CustomRoundButton, Demo_MVVM.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public CustomRoundButton (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == CustomRoundButton.class)
			mono.android.TypeManager.Activate ("Demo_MVVM.Droid.CustomRoundButton, Demo_MVVM.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public CustomRoundButton (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == CustomRoundButton.class)
			mono.android.TypeManager.Activate ("Demo_MVVM.Droid.CustomRoundButton, Demo_MVVM.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
