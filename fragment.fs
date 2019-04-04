uniform sampler2D u_Texture;
uniform float u_Threshold;

varying vec2 v_UV;

void main()
{
	//Ambient light
	vec3 ambientLight = vec3(0.1f, 0.1f, 0.1f);

	//Diffuse light
	
    gl_FragColor = texture2D(u_Texture, v_UV) * vec4(ambientLight, 1.f);
}