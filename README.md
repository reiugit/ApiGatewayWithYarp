# Api-Gateway with Yarp

* AddReverseProxy
<pre>
  builder.Services
      .AddReverseProxy()
      .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));
</pre>

* MapReverseProxy
<pre>
  app.MapReverseProxy();
</pre>
