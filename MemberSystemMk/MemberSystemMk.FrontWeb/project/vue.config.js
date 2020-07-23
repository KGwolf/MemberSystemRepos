const path = require('path');
const resolve = path.resolve;
module.exports = {
  devServer: {
    // 设置主机地址
    host: '127.0.0.1',
    // 设置默认端口
    port: 8080,
    // 配置自动启动浏览器
    open: true,
    // 设置代理
    proxy: {
      '/api': {
        // 目标 API 地址http://127.0.0.1/mmm
        target: 'http://127.0.0.1',
        // 如果要代理 websockets
        ws: true,
        // 将主机标头的原点更改为目标URL
        changeOrigin: true,
        pathRewrite: {
          '^/api': '/mmm'
        }
      }
    }
  },
  configureWebpack: {
    module: {
      rules: [
        {
          test: /\.m?js$/,
          // exclude用下面配置的话，默认是过滤不编译node_modules 路径下的文件
          // exclude: /(node_modules|bower_components)/,
          // include 指定需要编译的文件路径
          include: [
            resolve('src'),
            resolve('node_modules/tree-table-vue/lib'),
            resolve('node_modules/v-org-tree/dist'),
            resolve('node_modules/iview/src/locale')
          ],
          use: {
            loader: 'babel-loader',
            options: {
              presets: ['@babel/preset-env']
            }
          }
        }
      ]
    }
  },
  chainWebpack: config => {
    config.resolve.alias
      .set('@', resolve('src')) // key,value自行定义，比如.set('@@', resolve('src/components'))
      .set('_c', resolve('src/components'));
  },
  publicPath: process.env.NODE_ENV === 'production' ? '/dist/' : '/',
  productionSourceMap: false
};
