 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44394/',
  redirectUri: baseUrl,
  clientId: 'AbpLoginTest_App',
  responseType: 'code',
  scope: 'offline_access AbpLoginTest',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpLoginTest',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'AbpLoginTest',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
