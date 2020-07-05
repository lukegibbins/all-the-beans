const path = require("path")
const glob = require("glob")
const { VueLoaderPlugin } = require('vue-loader')

module.exports = {
    entry: glob.sync('./ClientApp/Applications/**.js').reduce(function (obj, el) {
        obj[path.parse(el).name] = el;
        return obj;
    }, {}),

    output: {
        path: __dirname + '/wwwroot/bundles',
        filename: '[name].bundle.js'
    },

    module: {
        rules: [
            {
                test: /\.css$/,
                use: [
                    'vue-style-loader',
                    'css-loader'
                ],
            }, {
                test: /\.vue$/,
                loader: 'vue-loader',
                options: {
                    loaders: {
                    }
                    // other vue-loader options go here
                }
            },
            {
                test: /\.js$/,
                loader: 'babel-loader',
                exclude: /node_modules/
            },
            {
                test: /\.(png|jpg|gif|svg)$/,
                loader: 'file-loader',
                options: {
                    name: '[name].[ext]?[hash]'
                }
            }
        ]
    },

    plugins: [
        new VueLoaderPlugin()
    ],

    mode: "production"
}
