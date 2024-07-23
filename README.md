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

* Configuration appsettings.json
<pre>
  ...
  "ReverseProxy": {

    "Routes": {
      "api1-route": {
        "ClusterID": "api1-cluster",
        "Match": {
          "Path": "/api1/{**catch-all}"
        },
        "Transforms": [
          { "PathPattern": "/{**catch-all}" }
        ]
      },
      "api2-route": {
        "ClusterID": "api2-cluster",
        "Match": {
          "Path": "/api2/{**catch-all}"
        },
        "Transforms": [
          { "PathPattern": "/{**catch-all}" }
        ]
      }
    },

    "Clusters": {
      "api1-cluster": {
        "Destinations": {
          "destination1": {
            "Address": "http://localhost:5001"
          }
        }
      },
      "api2-cluster": {
        "Destinations": {
          "destination1": {
            "Address": "http://localhost:5002"
          }
        }
      }
    }

  }
  ...
</pre>

